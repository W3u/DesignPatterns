using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	class OpAddCommand : Command
	{
		public OpAddCommand(Calculator calculator) : base(calculator)
		{
		}

		public override void Execute()
		{
			calculator.Add(num);
		}

		public override void UnExecute()
		{
			calculator.Sub(num);
		}
	}
}
