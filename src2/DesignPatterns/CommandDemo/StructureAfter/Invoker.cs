using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.StructureAfter
{
	/// <summary>
	/// Asks the command to carry out the request
	/// </summary>
	class Invoker
	{
		Command command;

		public void SetCommand(Command command)
		{
			this.command = command;
		}

		public void ExecuteCommand()
		{
			command.Execute();
		}

	}
}
