using System;

namespace ex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Taxpayer[] tps = new Taxpayer[2];
			string ssn;
			double ygi;
			
			for (int i = 0; i < tps.Length; i++) {
				Console.WriteLine("enter a social security number");
				ssn = Console.ReadLine();
				
				Console.WriteLine("enter the yearly gross income");
				while (!(Double.TryParse(Console.ReadLine(),out ygi))){
					Console.WriteLine("error, enter a number please");
					Console.WriteLine("enter the yearly gross income");
				}
				tps[i] = new Taxpayer(ssn,ygi);
			}
			foreach (Taxpayer item in tps) {
				Console.WriteLine(item);
			}
		}
	}
}

