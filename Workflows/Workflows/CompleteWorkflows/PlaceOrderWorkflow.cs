using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowsExperiment.Workflows.CompleteWorkflows
{
	using WorkflowsExperiment.DataAccess;
	using WorkflowsExperiment.Workflows.Steps;

	using global::Workflows;

	public class PlaceOrderWorkflow : WorkflowBase
	{
		private readonly Organization beneficiary;

		private readonly Product product;

		private readonly Organization payer;

		public PlaceOrderWorkflow(ManagementContext db, Organization beneficiary, Product product, Organization payer)
			: base(db)
		{
			this.beneficiary = beneficiary;
			this.product = product;
			this.payer = payer;

			var orderStep = new CreateOrderWorkflowStep(db, beneficiary, product, payer);
			var subStep = new AddSubscriptionWorkflowStep(db, beneficiary);

			this.Add(orderStep, 1);
			this.Add(subStep, 2);
		}
	}
}
