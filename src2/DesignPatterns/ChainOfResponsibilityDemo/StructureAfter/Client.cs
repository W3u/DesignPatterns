using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.StructureAfter
{
	/// <summary>
	/// Client:
	/// - initiates the request to a ConcreteHandler object on the chain
	/// </summary>
	class Client
	{
		static void Main(string[] args)
		{
			// setup chain of handler
			Handler previewHandler = new PreviewHanlder();
			Handler printHandler = new PrintHandler();
			previewHandler.SetSuccessor(printHandler);

			// issue the request
			PrintRequest printRequest = new PrintRequest();

			// process request
			previewHandler.HandleRequest(printRequest);
		}
	}
}
