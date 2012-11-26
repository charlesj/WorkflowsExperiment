namespace WorkflowsExperiment.Workflows.CompleteWorkflows
{
	using WorkflowsExperiment.DataAccess;
	using WorkflowsExperiment.Workflows.Steps;

	public class PlaceOrderWorkflow : WorkflowBase
	{
		public PlaceOrderWorkflow(ManagementContext db, Organization beneficiary, Product product, Organization payer)
			: base(db)
		{
			var orderStep = new CreateOrderWorkflowStep(db, beneficiary, product, payer);
			this.Add(orderStep, 1);

			if (product.Application != null)
			{
				var subStep = new AddSubscriptionWorkflowStep(db, beneficiary, product.Application);
				this.Add(subStep, 2);
			}
		}
	}
}
