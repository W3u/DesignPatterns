using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.StructureBefore
{
	/// <summary>
	/// Invoker
	/// </summary>
	class Invoker
	{
		private Receiver receiver;

		public Invoker(Receiver receiver)
		{
			this.receiver = receiver;
		}

		public void Execute()
		{
			this.receiver.Action();
		}

	}
}
