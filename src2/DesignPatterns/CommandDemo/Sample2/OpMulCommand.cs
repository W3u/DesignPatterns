using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	class OpMulCommand : Command
	{
		public OpMulCommand(Calculator calculator) : base(calculator)
		{
		}

		public override void Execute()
		{
			calculator.Mul(num);
		}

		public override void UnExecute()
		{
			calculator.Div(num);
		}
	}
}
