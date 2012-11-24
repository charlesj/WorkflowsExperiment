using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
