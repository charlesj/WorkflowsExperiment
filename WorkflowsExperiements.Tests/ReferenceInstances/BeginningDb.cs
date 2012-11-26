using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowsExperiment.Tests.ReferenceInstances
{
	using WorkflowsExperiment.DataAccess;

	public class BeginningDb
	{
		public static ManagementContext Build()
		{
			var rtn = new ManagementContext();

			var swis = new Application { Name = "SWIS" };
			var cico = new Application { Name = "CICO" };
			var isis = new Application { Name = "ISIS" };

			var trainingProduct = new Product { Name = "SWIS Training" };
			var swisSubscription = new Product { Name = "SWIS Subscription", Application = swis };
			var cicoSubscription = new Product { Name = "CICO Subscription", Application = cico };
			var isisSubscription = new Product { Name = "ISIS Subscription", Application = isis };

			var hogwarts = new Organization { Name = "Hogwarts" };
			var starfleet = new Organization { Name = "Starfleet Academy" };

			var hogwartsFinancial = new FinancialAccount { Organization = hogwarts };

			rtn.Applications.Add(swis);
			rtn.Applications.Add(cico);
			rtn.Applications.Add(isis);

			rtn.Products.Add(trainingProduct);
			rtn.Products.Add(swisSubscription);
			rtn.Products.Add(cicoSubscription);
			rtn.Products.Add(isisSubscription);

			rtn.Organizations.Add(hogwarts);
			rtn.Organizations.Add(starfleet);

			rtn.FinancialAccounts.Add(hogwartsFinancial);

			return rtn;
		}
	}
}
