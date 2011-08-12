using System;

namespace PatientLib
{
	public class InsuredPatient : Patient,IComparable
	{
		private static double[] insurancePercentages = {.8,.6,.25};
		private static string[] insuranceNames = {"Wrightstown Mutual","Red Umbrella","All other companies"};
		
		private string insuranceCompany;
		private double insuranceDiscount;
		
		InsuredPatient () : base(){}
		
		public InsuredPatient (string insuranceCompany,int id,int age,double amt,string name) : base(id,age,amt,name)
		{
			this.InsuranceCompany = insuranceCompany;
			
			// amountDue has special logic applied
			this.AmountDue = amt;
		}

		// this guy sets the insuranceDiscount in addition to it's normal duties
		public string InsuranceCompany {
			get {
				return this.insuranceCompany;
			}
			set {
				insuranceCompany = value;
				for (int i = 0; i < insuranceNames.Length; i++) {
					if (insuranceCompany.Equals(insuranceNames[i]))
					{
						insuranceDiscount = insurancePercentages[i];
						break;
					}
				}
			}
		}
		
		public double InsuranceDiscount {
			get {
				return this.insuranceDiscount;
			}
		}
		
		// here's the special logic referred to above...a discount, w00t
		public override double AmountDue {
			get {
				return this.amountDue;
			}
			set {
				amountDue = value - value*this.InsuranceDiscount;
			}
		}
		
		public new int CompareTo (object obj)
		{
			return base.CompareTo(obj);
		}

		public override bool Equals (object obj)
		{
			return base.Equals (obj);
		}

		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}
		
		public override string ToString ()
		{
			return string.Format("[InsuredPatient: Id={0}, Age={1}, AmountDue={2}, Name={3}, InsuranceCompany={4}, InsuranceDiscount={5}]",
			                     Id,Age,AmountDue.ToString("C"),
			                     Name,InsuranceCompany,InsuranceDiscount.ToString("P"));
		}
		
		public static void GetInsuranceName(out string name)
		{
			int choice;
			string menu = "enter the number corresponding to the patient's insurance company\n";
			for (int i=0; i < insuranceNames.Length; i++)
			{
				menu += i+1+". "+insuranceNames[i]+"\n";
			}
			menu += "\n$ ";
			
			Console.Write(menu);
			
			while (!Int32.TryParse(Console.ReadLine(),out choice))
			{
				Console.WriteLine("error. please enter the number next to the insurance option that most closely matches the patient's situation");
				Console.Write(menu);
				
			}
			name = insuranceNames[choice -1];
		}

	}
}


