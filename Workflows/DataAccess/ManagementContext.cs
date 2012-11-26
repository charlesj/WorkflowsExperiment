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

		public ManagementContext()
		{
			this.Organizations = new List<Organization>();
			this.Products = new List<Product>();
			this.Applications = new List<Application>();
			this.FinancialAccounts = new List<FinancialAccount>();
			this.Orders = new List<Order>();
			this.Subscriptions = new List<Subscription>();
		}

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

		public T Locate<T>(params object[] args)
		{
			// check to see if locator for type is loaded.  If not, load it
			throw new NotImplementedException("Locator not yet implemented");
		}
	}
}
