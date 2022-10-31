using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Sample2
{
	/// <summary>
	/// Request abstract class
	/// </summary>
	abstract class Request
	{
	}

	/// <summary>
	/// Concrete Request
	/// </summary>
	class AbsenceRequest : Request
	{
		public AbsenceRequest(string type, int leaveDays, string justification)
		{
			Type = type;
			LeaveDays = leaveDays;
			Justification = justification;
		}

		public string Type { get; set; }
		public int LeaveDays { get; set; }
		public string Justification { get; set; }

		public override string ToString()
		{
			return "{Type=" + Type + ",LeaveDays=" + LeaveDays + ",Justification=" + Justification + "}";
		}
	}

	/// <summary>
	/// Concrete Request
	/// </summary>
	class SalaryAdjustmentRequest : Request
	{
		public SalaryAdjustmentRequest(double increaseBy, string justification)
		{
			IncreaseBy = increaseBy;
			Justification = justification;
		}

		public double IncreaseBy { get; set; }
		public string Justification { get; set; }

		public override string ToString()
		{
			return "{IncreaseBy=" + IncreaseBy + ",Justification=" + Justification + "}";
		}
	}

}

