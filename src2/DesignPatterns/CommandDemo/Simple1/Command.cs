using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo.Simple1
{
	/// <summary>
	/// Command
	/// </summary>
	abstract class Command
	{
		protected Barbecuer receiver;

		public Command(Barbecuer receiver)
		{
			this.receiver = receiver;
		}

		public abstract void ExecuteCommand();

	}
}
