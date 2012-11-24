namespace WorkflowsExperiment.DataAccess
{
	public class Order
	{
		public Organization Payer { get; set; }
		public Organization Beneficiary { get; set; }

		public Product Product { get; set; }
	}
}
