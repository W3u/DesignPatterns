using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Simple1
{
	class BakeChickenWingCommand : Command
	{
		public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
		{

		}

		public override void ExecuteCommand()
		{
			receiver.BakeChickenWing();
		}
	}
}
