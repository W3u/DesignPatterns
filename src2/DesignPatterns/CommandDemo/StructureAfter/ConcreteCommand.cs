using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.StructureAfter
{
	/// <summary>
	/// Defines a binding bewteen a 'Receiver' object and an 'action'
	/// Implements Execute by invoking the corresponding operation(s) on Receiver
	/// </summary>
	class ConcreteCommand : Command
	{
		public ConcreteCommand(Receiver receiver) : base(receiver)
		{

		}

		public override void Execute()
		{
			base.receiver.Action();
		}
	}
}
