
namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;
	

	public class CreateOrderWorkflowStepResult : WorkflowStepResult
	{
		public Order Order { get; private set; }

		public CreateOrderWorkflowStepResult(bool success, string workDescription, string errorMessage, Order order)
			: base(success, workDescription, errorMessage)
		{
			this.Order = order;
		}
	}
}
