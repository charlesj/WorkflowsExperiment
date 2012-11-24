using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowsExperiment.DataAccess.Locaters
{
	public class FinancialAccountLocater : LocatorBase
	{
		public FinancialAccountLocater(ManagementContext db)
			: base(db)
		{
		}

		public FinancialAccount Locate(Organization organization)
		{
			return this.db.FinancialAccounts.Single(fa => fa.Organization == organization);
		}
	}
}
