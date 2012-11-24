using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowsExperiment.Tests
{
	using WorkflowsExperiment.DataAccess;
	using WorkflowsExperiment.Workflows.CompleteWorkflows;

	using Xunit;

	public class Sandbox
	{
		[Fact]
		public void Play()
		{
			var db = new ManagementContext();
			var beneficiary = new Organization();
			var product = new Product();
			var payer = new Organization();

			var workflow = new PlaceOrderWorkflow(db, beneficiary, product, payer);

			workflow.Execute();
		}
	}
}
