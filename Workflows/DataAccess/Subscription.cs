namespace WorkflowsExperiment.DataAccess
{
	public class Subscription
	{
		public Organization Subscriber { get; set; }

		public Application Application { get; set; }

		public Order Order { get; set; }
	}
}