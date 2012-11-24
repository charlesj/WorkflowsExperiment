using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowsExperiment.DataAccess
{
	public class ManagementContext
	{
		public List<Organization> Organizations { get; set; }
		public List<Product> Products { get; set; }
		public List<Application> Applications { get; set; }
		public List<FinancialAccount> FinancialAccounts { get; set; }
		public List<Order> Orders { get; set; }
		public List<Subscription> Subscriptions { get; set; }

		public void OpenTransaction()
		{
			
		}

		public void Rollback()
		{
			
		}

		public void CommitTransaction()
		{
			
		}

		public void SaveChanges()
		{
			
		}
	}
}
