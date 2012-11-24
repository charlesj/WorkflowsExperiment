
namespace WorkflowsExperiment.Workflows.Steps
{
	using WorkflowsExperiment.DataAccess;
	

	public class CreateOrderWorkflowStepResult : WorkflowStepResult
	{
		public Order Order { get; private set; }

		public Application Application { get; set; }

		public CreateOrderWorkflowStepResult(bool success, string workDescription, string successMessage, string errorMessage, Order order)
			: base(success, workDescription, successMessage, errorMessage)
		{
			this.Order = order;
		}
	}
}
