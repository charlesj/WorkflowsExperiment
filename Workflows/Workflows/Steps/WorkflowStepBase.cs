namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;

	public abstract class WorkflowStepBase 
	{
		protected readonly ManagementContext Context;

		protected WorkflowStepBase(ManagementContext context)
		{
			this.Context = context;
		}

		public abstract string PreWorkDescription { get; }

		public abstract string PostWorkDescription { get; }
	}
}