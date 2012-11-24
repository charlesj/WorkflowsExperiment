namespace WorkflowsExperiment.Workflows.Steps
{
	public abstract class WorkflowStepResult
	{
		protected WorkflowStepResult(bool success, string workDescription, string successMessage, string errorMessage)
		{
			Success = success;
			WorkDescription = workDescription;
			SuccessMessage = successMessage;
			ErrorMessage = errorMessage;
		}

		public bool Success { get; private set; }
		public string WorkDescription { get; private set; }
		public string SuccessMessage { get; private set; }
		public string ErrorMessage { get; private set; }
	}
}