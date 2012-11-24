namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;

	public class AddSubscriptionWorkflowStep : WorkflowStepBase
	{
		private readonly Organization subscriber;

		public AddSubscriptionWorkflowStep(ManagementContext context, Organization subscriber)
			: base(context)
		{
			this.subscriber = subscriber;
		}

		public AddSubscriptionWorkflowStepResult Run(Order order, Application application)
		{
			var subscription = new Subscription{Subscriber = subscriber};
			var result = new AddSubscriptionWorkflowStepResult(true, "", "", "", subscription);
			return result;
		}
	}
}