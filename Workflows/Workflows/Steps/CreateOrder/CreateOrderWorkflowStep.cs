namespace Workflows
{
	using WorkflowsExperiment.DataAccess;
	using WorkflowsExperiment.Workflows.Steps;

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
			var order = new Order();
			return new CreateOrderWorkflowStepResult(true, "Created a new order", "order created was successful", "no errors", order);
		}
	}
}