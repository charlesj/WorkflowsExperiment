namespace WorkflowsExperiment.DataAccess.Locaters
{
	public abstract class LocatorBase
	{
		protected readonly ManagementContext db;

		public LocatorBase(ManagementContext db)
		{
			this.db = db;
		}
	}
}
