namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;

	public class CreateOrderWorkflowStep : WorkflowStepBase
	{
		private readonly Organization beneficiary;

		private readonly Product product;

		private readonly Organization payer;

		public CreateOrderWorkflowStep(ManagementContext context, Organization beneficiary, Product product, Organization payer)
			: base(context)
		{
			this.beneficiary = beneficiary;
			this.product = product;
			this.payer = payer;
		}

		public CreateOrderWorkflowStepResult Run()
		{
			// Create the order
			var order = new Order {Beneficiary = beneficiary, Product = product, Payer = payer};
			return new CreateOrderWorkflowStepResult(true, this.PostWorkDescription, string.Empty, order);
		}

		public override string PreWorkDescription
		{
			get
			{
				return string.Format("An order will be created with beneficiary {0} and payer {1} for product {2}", beneficiary.Name, payer.Name, product.Name);
			}
		}

		public override string PostWorkDescription
		{
			get
			{
				return string.Format("An order was created with beneficiary {0} and payer {1} for product {2}", beneficiary.Name, payer.Name, product.Name);
			}
		}
	}
}