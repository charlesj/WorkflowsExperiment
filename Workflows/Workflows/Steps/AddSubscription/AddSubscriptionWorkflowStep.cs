namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;

	public class AddSubscriptionWorkflowStep : WorkflowStepBase
	{
		private readonly Organization subscriber;

		private readonly Application application;

		public AddSubscriptionWorkflowStep(ManagementContext context, Organization subscriber, Application application)
			: base(context)
		{
			this.subscriber = subscriber;
			this.application = application;
		}

		public AddSubscriptionWorkflowStepResult Run(Order order)
		{
			var subscription = new Subscription{Subscriber = subscriber, Application = this.application, Order = order};
			var result = new AddSubscriptionWorkflowStepResult(true, this.PostWorkDescription, "", subscription);
			return result;
		}

		public override string PreWorkDescription
		{
			get
			{
				return string.Format("A {0} subscription will be created for {1}", this.application.Name, this.subscriber.Name);
			}
		}

		public override string PostWorkDescription
		{
			get
			{
				return string.Format("A {0} subscription was created for {1}", this.application.Name, this.subscriber.Name);
			}
		}
	}
}