namespace WorkflowsExperiment.Tests
{
	using System;
	using System.Linq;

	using WorkflowsExperiment.DataAccess;
	using WorkflowsExperiment.Tests.ReferenceInstances;
	using WorkflowsExperiment.Workflows.CompleteWorkflows;

	using Xunit;

	public class Sandbox
	{
		[Fact]
		public void Play()
		{
			var db = BeginningDb.Build();
			var beneficiary = db.Organizations.Single(org => org.Name == "Hogwarts");
			var product = db.Products.Single(prod => prod.Name == "SWIS Subscription");
			var payer = db.Organizations.Single(org => org.Name == "Hogwarts");

			var workflow = new PlaceOrderWorkflow(db, beneficiary, product, payer);

			workflow.GetPreWorkDescription().ForEach(Console.WriteLine);

			var result = workflow.Execute();

			result.DescribeResults().ForEach(Console.WriteLine);
		}
	}
}
