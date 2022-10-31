using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	class OpDivCommand : Command
	{
		public OpDivCommand(Calculator calculator) : base(calculator)
		{
		}

		public override void Execute()
		{
			calculator.Div(num);
		}

		public override void UnExecute()
		{
			calculator.Mul(num);
		}
	}
}
