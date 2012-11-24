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
			var subStep = new AddSubscriptionWorkflowStep(db, beneficiary);

			this.Add(orderStep, 1);
			this.Add(subStep, 2);
		}
	}
}
