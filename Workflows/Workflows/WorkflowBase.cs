namespace WorkflowsExperiment.Workflows
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using WorkflowsExperiment.DataAccess;
	using WorkflowsExperiment.Workflows.Steps;

	public abstract class WorkflowBase
	{
		private readonly ManagementContext db;

		private readonly List<WorkflowStepWrapper> steps;

		private readonly List<Tuple<string, Type, int>> availableParams; 

		public WorkflowBase(ManagementContext db)
		{
			this.db = db;
			this.steps = new List<WorkflowStepWrapper>();
			this.availableParams = new List<Tuple<string, Type, int>>();
		}

		protected void Add(WorkflowStepBase step, int stepNumber)
		{
			var type = step.GetType();
			// get the method called 'run'
			var runMethod = type.GetMethod("Run");
			// get the return type of the method
			var returnType = runMethod.ReturnType;
			// TODO: Insure that return type inherits from WorkflowStepResultBase

			// get the returnType properties, in order to filter them out.
			var unusableTypeList = new List<string> { "Success", "WorkDescription", "SuccessMessage", "ErrorMessage" };
			var returnTypeProps = returnType.GetProperties().ToList().Where(p => !unusableTypeList.Contains(p.Name));
			
			foreach (var returnTypeProp in returnTypeProps)
			{
				// must add one to the available step, because otherwise, it would be passing something to itself, which wouldn't be correct;
				availableParams.Add(Tuple.Create(returnTypeProp.Name, returnTypeProp.PropertyType, stepNumber + 1));
			}
			
			var args = runMethod.GetParameters();
			// if there are args (there might not be any)
			// see if there are any available types that have the same name (ignoring case) and same type.  There should only ever be exactly 1
			if (args.Any() && args.Any(arg => availableParams.Count(at => String.Compare(arg.Name, at.Item1, StringComparison.OrdinalIgnoreCase) == 0 && arg.ParameterType == at.Item2 && at.Item3 <= stepNumber) != 1))
			{
				throw new WorkflowStepAdditionException("Attempted to add a workflow step that would be unable to execute.");
			}

			this.steps.Add(new WorkflowStepWrapper(){ ExecutionMethod = runMethod, Order = stepNumber, WorkflowStep = step});

		}

		public WorkflowResult Execute()
		{
			WorkflowResult results = new WorkflowResult();
			this.db.OpenTransaction();
			foreach (var step in this.steps)
			{
				// run the step.
				var resultObj = step.ExecutionMethod.Invoke(step.WorkflowStep, step.BuildArgs(availableParams));
				if (resultObj is WorkflowStepResult)
				{
					var stepResult = resultObj as WorkflowStepResult;
					// add the step to the results
					results.Results.Add(stepResult);
					// if the step was not sucessful, break from the running
					// and rollback the transaction
					if (!stepResult.Success)
					{
						this.db.Rollback();
						break;
					}
				}
			}

			// if they were all successful, commit the transaction.
			if (results.TotalSuccess)
			{
				this.db.SaveChanges();
				this.db.CommitTransaction();
			}

			return results;
		}

	}

	public class WorkflowStepAdditionException : Exception
	{
		public WorkflowStepAdditionException(string message)
			: base(message)
		{
			
		}
	}
}