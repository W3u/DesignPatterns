using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Sample1
{
	/// <summary>
	/// Handler abstract class
	/// </summary>
	abstract class BasicSuppport
	{
		private string name;
		private BasicSuppport successor;

		public BasicSuppport(string name)
		{
			this.name = name;
		}

		public BasicSuppport SetSuccessor(BasicSuppport support)
		{
			successor = support;
			return successor;
		}

		public void Support(Trouble trouble)
		{
			if (CanResolve(trouble))
			{
				Done(trouble);
			}
			else if (successor != null)
			{
				successor.Support(trouble);
			}
			else
			{
				Fail(trouble);
			}
		}

		protected abstract bool CanResolve(Trouble trouble);

		protected virtual void Done(Trouble trouble)
		{
			Console.WriteLine(trouble + " is resolved by " + this + ".");
		}

		protected virtual void Fail(Trouble trouble)
		{
			Console.WriteLine(trouble + " cannot be resolved");
		}

		public override string ToString()
		{
			return "[" + name + "]";
		}
	}

	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class NoSupport : BasicSuppport
	{
		public NoSupport(string name) : base(name)
		{

		}
		protected override bool CanResolve(Trouble trouble)
		{
			return false;
		}
	}

	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class LimitSupport : BasicSuppport
	{
		private int limit;
		public LimitSupport(string name, int limit) : base(name)
		{
			this.limit = limit;
		}
		protected override bool CanResolve(Trouble trouble)
		{
			if (trouble.GetNumber() < limit)
				return true;
			return false;
		}
	}

	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class OddSupport : BasicSuppport
	{
		public OddSupport(string name) : base(name)
		{

		}
		protected override bool CanResolve(Trouble trouble)
		{
			if (trouble.GetNumber() % 2 == 1)
				return true;
			return false;
		}
	}

	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class SpecialSupport : BasicSuppport
	{
		private int number;
		public SpecialSupport(string name, int number) : base(name)
		{
			this.number = number;
		}
		protected override bool CanResolve(Trouble trouble)
		{
			if (trouble.GetNumber() == number)
				return true;
			return false;
		}
	}

}
