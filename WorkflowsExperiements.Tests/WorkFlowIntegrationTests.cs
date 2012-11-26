namespace WorkflowsExperiment.Tests
{
	using System;
	using System.Linq;

	using WorkflowsExperiment.Tests.ReferenceInstances;
	using WorkflowsExperiment.Workflows.CompleteWorkflows;

	using Xunit;

	public class WorkFlowIntegrationTests
	{
		[Fact]
		public void PlaceOrderWorkflowWithProductWithApplication()
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

		[Fact]
		public void PlaceOrderWorkflowWithProductWithoutApplication()
		{
			var db = BeginningDb.Build();
			var beneficiary = db.Organizations.Single(org => org.Name == "Hogwarts");
			var product = db.Products.Single(prod => prod.Name == "SWIS Training");
			var payer = db.Organizations.Single(org => org.Name == "Hogwarts");

			var workflow = new PlaceOrderWorkflow(db, beneficiary, product, payer);

			workflow.GetPreWorkDescription().ForEach(Console.WriteLine);

			var result = workflow.Execute();

			result.DescribeResults().ForEach(Console.WriteLine);
		}
	}
}
