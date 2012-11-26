namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;

	public class AddSubscriptionWorkflowStepResult : WorkflowStepResult
	{
		public Subscription Subscription { get; private set; }

		public AddSubscriptionWorkflowStepResult(bool success, string workDescription, string errorMessage, Subscription subscription)
			: base(success, workDescription, errorMessage)
		{
			this.Subscription = subscription;
		}
	}
}