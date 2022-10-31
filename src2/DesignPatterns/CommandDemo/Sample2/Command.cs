using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	/// <summary>
	/// Command
	/// </summary>
	abstract class Command
	{
		protected Calculator calculator;
		protected double num;

		public Command(Calculator calculator)
		{
			this.calculator = calculator;
		}

		public void SetOpNum(double n)
		{
			this.num = n;
		}

		public abstract void Execute();

		public abstract void UnExecute();


	}
}
