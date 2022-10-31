using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.StructureAfter
{
	/// <summary>
	/// ConcreteHandler: 
	/// - handles requests it is responsible for 
	/// - can access its successor
	/// - if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
	/// </summary>
	class PrintHandler : Handler
	{
		public virtual void HandleRequest(Request request)
		{
			if (request is PrintRequest)
			// if (request.GetTopic() == "Print")
			{
				// handle the print request...
			}
			else if (_successor != null)
			{
				_successor.HandleRequest(request);
			}
		}

	}
}
