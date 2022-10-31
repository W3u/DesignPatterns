using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	class OpSubCommand : Command
	{
		public OpSubCommand(Calculator calculator) : base(calculator)
		{
		}

		public override void Execute()
		{
			calculator.Sub(num);
		}

		public override void UnExecute()
		{
			calculator.Add(num);
		}
	}
}
