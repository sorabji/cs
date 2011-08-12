using System;
namespace exLib5
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
			exLib5.Patient other = (exLib5.Patient)obj;
			return Id == other.Id;
		}

		public override int GetHashCode ()
		{
			unchecked {
				return Id.GetHashCode ();
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
			return string.Format ("[Patient: Id={0}, Age={1}, AmountDue={2}, Name={3}]",
				Id, Age, AmountDue, Name);
		}
		
	

	}
}

