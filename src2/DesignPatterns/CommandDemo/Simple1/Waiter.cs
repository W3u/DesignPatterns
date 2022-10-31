using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Simple1
{
	/// <summary>
	/// Invoker
	/// </summary>
	class Waiter
	{
		private IList<Command> orders=new List<Command>();

		public void SetOrder(Command command)
		{
			if(command is BakeChickenWingCommand)
			{
				Console.WriteLine("No chicken wing left, pls order something else...");
			}
			else if(command is BakeMuttonCommand)
			{
				orders.Add(command);
			}

		}

		public void CancelOrder(Command command)
		{
			orders.Remove(command);
			Console.WriteLine("cancelled order");
		}

		public void Notify()
		{
			foreach (var item in orders)
			{
				item.ExecuteCommand();
			}
		}

	}
}
