using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Sample1
{
	/// <summary>
	/// Client
	/// </summary>
	class Client
	{
		public static void Main(string[] args)
		{
			BasicSuppport supportChain = BuildChain();

			for (int i = 0; i < 500; i += 33)
			{
				supportChain.Support(new Trouble(i));
			}
		}

		private static BasicSuppport BuildChain()
		{
			BasicSuppport nosupport = new NoSupport("No");
			BasicSuppport limit100 = new LimitSupport("Limit100", 100);
			BasicSuppport special429 = new SpecialSupport("Special429", 429);
			BasicSuppport limit200 = new LimitSupport("limit200", 200);
			BasicSuppport odd = new OddSupport("odd");
			BasicSuppport limit300 = new LimitSupport("limit300", 300);

			nosupport.SetSuccessor(limit100).SetSuccessor(special429).SetSuccessor(limit200).SetSuccessor(odd).SetSuccessor(limit300);

			return nosupport;
		}


	}
}
