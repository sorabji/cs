using System;
namespace ex
{
	public class Taxpayer
	{
		private const double lowTax = 0.15, highTax = 0.28;
		private string ssn;
		private double yGrossIncome,taxOwed;
		
		public Taxpayer () {}
		
		public Taxpayer (string ssn, double yGrossIncome)
		{
			this.ssn = ssn;
			YGrossIncome = yGrossIncome;
		}
		
		public string Ssn {
			get {
				return this.ssn;
			}
			set {
				ssn = value;
			}
		}

		public double YGrossIncome {
			get {
				return this.yGrossIncome;
			}
			set {
				yGrossIncome = value;
				if (yGrossIncome < 30000){
					taxOwed = yGrossIncome*lowTax;
				} else if (yGrossIncome >= 30000){
					taxOwed = yGrossIncome*highTax;
				}
			}
		}

		public double TaxOwed {
			get {
			return this.taxOwed;
			}
		}
		
		public override string ToString ()
		{
			return string.Format ("[Taxpayer: \n\tssn= {0}\n\tyGrossIncome= {1}\n\ttaxOwed= {2}]", 
			                      ssn, 
			                      yGrossIncome.ToString("c"), 
			                      taxOwed.ToString("C"));
		}

	}
}

