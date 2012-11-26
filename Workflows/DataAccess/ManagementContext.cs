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

		public T Find<T>(params object[] args)
		{
			// check to see if locator for type is loaded.  If not, load it
			throw new NotImplementedException("Locator not yet implemented");

			// okay the idea here is simple
			// there are locators that all inherit from Locatorbase
			// I can look for a type (and store a reference to it in case I need it later)
			// I can look for a Find() method on it that uses arguments with the type as the arguments passed into this 
			// then I call that method and return it on this function
			// so example usage: var org = db.Find<Organization>("Hogwarts");

			// in this case, I would look for an Organization Locator.  If it's found, this I look for a method called "Find" 
			// with a type signature of (string) and a return type of Organization (check return type just to be safe)
			// that gets found, then I call that method and return the results.

			// things *could* get a bit tricky with argument ordering.  perhaps there is a fit for dynamic in here.
		}

		public List<T> FindMultiple<T>(params object[] args)
		{
			// same idea as above, but for multiple results
			throw new NotImplementedException("Locator not yet implemented");
		}
	}
}
