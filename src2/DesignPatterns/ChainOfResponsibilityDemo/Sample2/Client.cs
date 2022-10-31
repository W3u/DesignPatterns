using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Sample2
{
	class Client
	{
		public static void Main(string[] args)
		{
			// setup chain of appover
			Approver approver = BuildChain();

			// generate the requests
			Request vocation10Days = new AbsenceRequest("Vocation", 10, "");
			Request vocation17Days = new AbsenceRequest("Vocation", 17, "");
			Request salary30Increasement = new SalaryAdjustmentRequest(30.0, "");

			// process requests
			approver.HandleRequest(vocation10Days);
			approver.HandleRequest(vocation17Days);
			approver.HandleRequest(salary30Increasement);
		}

		private static Approver BuildChain()
		{
			VicePresident vp = new VicePresident(10, 30.0);
			SeniorVicePresident svp = new SeniorVicePresident(30);
			Director director = new Director();

			vp.SetSuccessor(svp);
			svp.SetSuccessor(director);
			
			return vp;
		}
	}
}