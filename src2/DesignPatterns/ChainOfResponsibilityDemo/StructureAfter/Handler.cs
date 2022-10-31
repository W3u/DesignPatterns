using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.StructureAfter
{
	/// <summary>
	/// Handler:
	/// - defines an interface for handling the requests
	/// - implements the successor link (optional)
	/// </summary>
	abstract class Handler
	{
		protected Handler _successor;

		public void SetSuccessor(Handler successor)
		{
			this._successor = successor;
		}

		public virtual void HandleRequest(Request request)
		{
			if (_successor != null)
			{
				_successor.HandleRequest(request);
			}
		}

	}
}
