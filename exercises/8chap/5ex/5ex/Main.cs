using System;
using PatientLib;

namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//PatientDemo1();
			PatientDemo2();
		}
		public static void PatientDemo1()
		{
			int id,age;
			string name;
			double amtOwed,totalAmtOwed = 0;
			
			Patient[] patients = new Patient[5];
			for (int i = 0; i < patients.Length; i++) 
			{
				Patient.GetPatientId(out id);
				foreach (Patient item in patients) 
				{
					if (item != null)
					{
						while (item.Id == id)
						{
							Console.WriteLine("{0} is already taken",item.Id);
							Console.WriteLine("patient id's must be unique!");
							Patient.GetPatientId(out id);
						}
					}
				}
				Patient.GetPatientAge(out age);
				Patient.GetPatientName(out name);
				Patient.GetPatientAmtOwed(out amtOwed);
				patients[i] = new Patient(id,age,amtOwed,name);
				totalAmtOwed += amtOwed;
			}
			Array.Sort(patients);
			foreach (Patient item in patients)
			{
					Console.WriteLine(item);	
			}	
			Console.WriteLine("total amount owed: {0}",totalAmtOwed.ToString("C"));	
		}
				
		public static void PatientDemo2()
		{
			int id,age;
			string name,insuranceCompany;
			double amtOwed,totalAmtOwed = 0;
			
			InsuredPatient[] insuredPatients = new InsuredPatient[5];
			for (int i = 0; i < insuredPatients.Length; i++) 
			{
				InsuredPatient.GetPatientId(out id);
				foreach (InsuredPatient item in insuredPatients) 
				{
					if (item != null)
					{
						while (item.Id == id)
						{
							Console.WriteLine("{0} is already taken",item.Id);
							Console.WriteLine("patient id's must be unique!");
							InsuredPatient.GetPatientId(out id);
						}
					}
				}
				InsuredPatient.GetPatientAge(out age);
				InsuredPatient.GetPatientName(out name);
				InsuredPatient.GetPatientAmtOwed(out amtOwed);
				InsuredPatient.GetInsuranceName(out insuranceCompany);
				
				insuredPatients[i] = new InsuredPatient(insuranceCompany,id,age,amtOwed,name);
				// hack around since amtOwed logic only kicks in after the constructor
				amtOwed = insuredPatients[i].AmountDue;
				totalAmtOwed += amtOwed;
			}
			Array.Sort(insuredPatients);
			foreach (InsuredPatient item in insuredPatients)
			{
					Console.WriteLine(item);	
			}	
			Console.WriteLine("total amount owed: {0}",totalAmtOwed.ToString("C"));	
		}
	}
}

