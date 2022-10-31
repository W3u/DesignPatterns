using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.StructureAfter
{
	/// <summary>
	/// Declares an interface for executing an operation
	/// </summary>
	abstract class Command
	{
		protected Receiver receiver;

		public Command(Receiver receiver)
		{
			this.receiver = receiver;
		}

		public abstract void Execute();
	}
}
