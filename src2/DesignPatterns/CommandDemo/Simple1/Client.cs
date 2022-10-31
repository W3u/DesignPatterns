using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Simple1
{
	class Client
	{
		static void Main(string[] args)
		{
			Barbecuer boy = new Barbecuer();
			Command bakeMuttonCmd = new BakeMuttonCommand(boy);
			Command bakeChickenWingCmd = new BakeChickenWingCommand(boy);

			Waiter waiter = new Waiter();



			Console.ReadKey();
		}
	}
}
