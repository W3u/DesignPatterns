using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Sample2
{
	/// <summary>
	/// Handler abstract class
	/// </summary>
	abstract class Approver
	{
		protected Approver _successor;
		public void SetSuccessor(Approver approver)
		{
			_successor = approver;
		}

		public void HandleRequest(Request request)
		{
			if (request is AbsenceRequest
				&& CanApproveAbsence((AbsenceRequest)request))
			{
				ApproveAbsence((AbsenceRequest)request);
			}
			else if (request is SalaryAdjustmentRequest
				&& CanApproveSalaryAdjustment((SalaryAdjustmentRequest)request))
			{
				ApproveSalaryAdjustment((SalaryAdjustmentRequest)request);
			}
			else if (_successor != null)
			{
				_successor.HandleRequest(request);
			}
			else
			{
				// Handle no appropriate handler
				Console.WriteLine("Cannot find appropriate approver");
				// throw new Exception();
			}
		}

		protected abstract bool CanApproveAbsence(AbsenceRequest request);
		protected abstract bool CanApproveSalaryAdjustment(SalaryAdjustmentRequest request);

		protected virtual void ApproveAbsence(AbsenceRequest request)
		{
			Console.WriteLine("Absence request " + request + " is approved by " + this);
		}

		protected virtual void ApproveSalaryAdjustment(SalaryAdjustmentRequest request)
		{
			Console.WriteLine("Salary adjustment request " + request + " is approved by " + this);
		}
	}



	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class VicePresident : Approver
	{
		private int limitedLeaveDays;
		private double limitedAdjustedSalary;

		public VicePresident(int limitedLeaveDays, double limitedAdjustedSalary)
		{
			this.limitedLeaveDays = limitedLeaveDays;
			this.limitedAdjustedSalary = limitedAdjustedSalary;
		}

		protected override bool CanApproveAbsence(AbsenceRequest request)
		{
			if (request.LeaveDays <= limitedLeaveDays)
				return true;
			return false;
		}

		protected override bool CanApproveSalaryAdjustment(SalaryAdjustmentRequest request)
		{
			if (request.IncreaseBy <= limitedAdjustedSalary)
				return true;
			return false;
		}

		public override string ToString()
		{
			return $"VP (Days={limitedLeaveDays},Salary={limitedAdjustedSalary})";
		}
	}

	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class SeniorVicePresident : Approver
	{
		private int limitedLeaveDays;

		public SeniorVicePresident(int limitedLeaveDays)
		{
			this.limitedLeaveDays = limitedLeaveDays;
		}

		protected override bool CanApproveAbsence(AbsenceRequest request)
		{
			if (request.LeaveDays <= limitedLeaveDays)
				return true;
			return false;
		}

		protected override bool CanApproveSalaryAdjustment(SalaryAdjustmentRequest request)
		{
			return true;
		}

		public override string ToString()
		{
			return $"SVP(Days={limitedLeaveDays})";
		}
	}

	/// <summary>
	/// ConcreteHandler
	/// </summary>
	class Director : Approver
	{
		private int limitedLeaveDays;
		private double limitedAdjustedSalary;

		public Director()
		{
		}

		protected override bool CanApproveAbsence(AbsenceRequest request)
		{
			return true;
		}

		protected override bool CanApproveSalaryAdjustment(SalaryAdjustmentRequest request)
		{
			return true;
		}

		public override string ToString()
		{
			return $"Director (Days={limitedLeaveDays},Salary={limitedAdjustedSalary})";
		}

	}

}
