using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowsExperiment.Workflows
{
	using System.Reflection;

	using WorkflowsExperiment.Workflows.Steps;

	public class WorkflowStepWrapper
	{
		public WorkflowStepBase WorkflowStep { get; set; }

		public int Order { get; set; }

		public MethodInfo ExecutionMethod { get; set; }

		public List<Tuple<string, Type>> ExecutionParameters;

		public object[] BuildArgs(List<Tuple<string, Type, int>> availableParams)
		{
			throw new NotImplementedException();
		}
	}
}
