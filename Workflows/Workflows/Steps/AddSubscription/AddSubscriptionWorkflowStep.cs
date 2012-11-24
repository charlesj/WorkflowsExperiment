namespace WorkflowsExperiment.Workflows.Steps
{
	using System;
	using System.Collections.ObjectModel;

	using WorkflowsExperiment.DataAccess;

	public class AddSubscriptionWorkflowStep : WorkflowStepBase
	{
		public AddSubscriptionWorkflowStep(ManagementContext context, Organization subscriber)
			: base(context)
		{
		}

		public AddSubscriptionWorkflowStepResult Run(Order order)
		{
			var subscription = new Subscription();			
			var result = new AddSubscriptionWorkflowStepResult(true, "", "", "", subscription);
			return result;
		}
	}

	public class AddSubscriptionWorkflowStepResult : WorkflowStepResult
	{
		public Subscription Subscription { get; private set; }

		public AddSubscriptionWorkflowStepResult(bool success, string workDescription, string successMessage, string errorMessage, Subscription subscription)
			: base(success, workDescription, successMessage, errorMessage)
		{
			this.Subscription = subscription;
		}
	}
}