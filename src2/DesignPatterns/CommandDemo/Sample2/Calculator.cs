using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Sample2
{
	/// <summary>
	/// Receiver
	/// </summary>
	class Calculator
	{
		private double _sum;

		public Calculator()
		{
			_sum = 0;
		}

		public void Add(double n)
		{
			_sum += n;
			Console.WriteLine("> + {0} = {1}", n, _sum);
		}

		public void Sub(double n)
		{
			_sum -= n;
			Console.WriteLine("> - {0} = {1}", n, _sum);
		}

		public void Mul(double n)
		{
			_sum *= n;
			Console.WriteLine("> * {0} = {1}", n, _sum);
		}

		public void Div(double n)
		{
			_sum /= n;
			Console.WriteLine("> / {0} = {1}", n, _sum);
		}

		public double GetResult()
		{
			return _sum;
		}

	}
}
