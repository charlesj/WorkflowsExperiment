

namespace WorkflowsExperiment.DataAccess.Locaters
{
	using System.Linq;

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
