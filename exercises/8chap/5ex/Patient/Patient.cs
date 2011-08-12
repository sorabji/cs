using System;
namespace PatientLib
{
	public class Patient : IComparable
	{
		private int id,age;
		private double amountDue;
		private string name;
		
		public Patient (){}
		
		public Patient (int id, int age, double amountDue, string name)
		{
			this.id = id;
			this.age = age;
			this.amountDue = amountDue;
			this.name = name;
		}

		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public int Age {
			get {
				return this.age;
			}
			set {
				age = value;
			}
		}

		public double AmountDue {
			get {
				return this.amountDue;
			}
			set {
				amountDue = value;
			}
		}

		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}
		
		public override bool Equals (object obj)
		{
			if (obj == null)
				return false;
			if (ReferenceEquals (this, obj))
				return true;
			if (obj.GetType () != typeof(Patient))
				return false;
			Patient other = (Patient)obj;
			return Id == other.Id;
		}

		public override int GetHashCode ()
		{
			unchecked {
				return Id;
			}
		}
		
		public int CompareTo (object obj)
		{
			if (!(obj is Patient))
			{
				throw new ArgumentException (
					"can't compare objects of differing types");
			}
			Patient p = (Patient) obj;
			if (this.Id == p.Id) return 0;
			return this.Id < p.Id ? 1: -1;
		}

		
		public override string ToString ()
		{
			// the hell is wrong w/ this line?
			//return string.Format ("[Patient: Id={0}, Age={1}, AmountDue={2}, Name={3}]",
				//Id, Age, AmountDue.ToString, Name);
			string tmp = string.Format("[Patient: Id={0}, Age={1}, AmountDue={2}, Name={3}]",Id,Age,AmountDue.ToString("C"),Name);
			return tmp;
		}
			
		public static void GetPatientId(out int id)
		{
			string message = "enter the patient's id number\n$ ";
			Console.Write (message);
			while (!Int32.TryParse(Console.ReadLine(),out id)) {
				Console.WriteLine("error, please enter a number for the patient's id");	
				Console.Write (message);
			}
		}
		
		public static void GetPatientName(out string name)
		{
			string message = "enter the patient's name\n$ ";
			Console.Write (message);
			name = Console.ReadLine();
		}
		
		public static void GetPatientAmtOwed(out double amt)
		{
			string message = "enter the amount owed by the patient\n$ ";
			Console.Write (message);
			while (!Double.TryParse(Console.ReadLine(),out amt)) {
				Console.WriteLine("error, please enter a number for the amount owed by the patient");
				Console.Write(message);
			}
		}
		
		public static void GetPatientAge(out int age)
		{
			string message = "enter the patient's age\n$ ";
			Console.Write(message);
			while (!Int32.TryParse(Console.ReadLine(),out age)) {
				Console.WriteLine("error, please enter a number for the patient's age");
				Console.Write(message);
			}
		}

	}
}

