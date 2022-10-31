using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.StructureAfter
{
	/// <summary>
	/// How to represent request ?
	/// You can implement specific request by deriving from it.
	/// </summary>
	abstract class Request
	{
		/// <summary>
		/// Optional:
		/// The accessor to show the request type.
		/// In C#, we can use 'is' keyword to identify request type.
		/// </summary>
		/// <returns></returns>
		public virtual string GetTopic()
		{
			return "Default";
		}
	}

	class PreviewRequest : Request
	{
		public override string GetTopic()
		{
			return "Preview";
		}
	}

	class PrintRequest : Request
	{
		public override string GetTopic()
		{
			return "Print";
		}
	}

}
