using System;
using PatientLib;



namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
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
		

	}
}

