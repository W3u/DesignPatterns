using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.StructureAfter
{
	/// <summary>
	/// Creates a ConcreteCommand object and sets its receiver
	/// </summary>
	class Client
	{
		static void Main(string[] args)
		{
			// Create receiver, command and invoker
			Receiver receiver = new Receiver();
			Command command = new ConcreteCommand(receiver);
			Invoker invoker = new Invoker();

			// Set and execute command
			invoker.SetCommand(command);
			invoker.ExecuteCommand();

			Console.ReadKey();
		}

	}
}
