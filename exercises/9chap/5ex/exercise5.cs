using System;

public class Employee{
	private double id,hourlyWage;	
	public Employee (double id, double hourlyWage)
	{
		this.Id = id;
		this.HourlyWage = hourlyWage;
	}
		public double Id {
		get {
			return this.id;
		}
		set {
			id = value;
		}
	}

	public double HourlyWage {
		get {
			return this.hourlyWage;
		}
		set {
			if (value < 6 || value > 50){
				throw new ArgumentException("hourly wage must be between 6 and 50");
			} else {
			hourlyWage = value;
			}
		}
	}		
	
	public override string ToString ()
	{
		return string.Format ("[Employee: Id={0}, HourlyWage={1}]", Id, HourlyWage.ToString("C"));
	}
}

public class Run{
	public static void Main(String[] argv){
		//EmployeeExceptionDemo1();
		EmployeeExceptionDemo2();
	}
	public static void EmployeeExceptionDemo1(){
		Employee e1,e2,e3;
		try {
			// over the limit
			e1 = new Employee(2,60);
		} catch (ArgumentException) {
			Console.WriteLine("error message");	
		}
		try {
			// below the limit
			e2 = new Employee(3,1);
		} catch (ArgumentException) {
			Console.WriteLine("error message");	
		}
		try {
			// within the allowed range
			e3 = new Employee(4,45);
		} catch (ArgumentException) {
			Console.WriteLine("error message");	
		}
	}
	public static void EmployeeExceptionDemo2(){
		Employee[] employees = new Employee[5];
		double id,hourlyWage;
		for (int i = 0; i < employees.Length; i++) {
			try{
				// can exception handling get any worse than this? 
				// book gets what the book wants though
				Console.Write("enter the id number of the employee\n$  ");
				id = Double.Parse(Console.ReadLine());
				Console.Write("enter the hourly wage of the employee\n$  ");
				hourlyWage = Double.Parse(Console.ReadLine());
				
				employees[i] = new Employee(id,hourlyWage);
				
				// says to catch ANY exception thrown...
			} catch (Exception){
				employees[i] = new Employee(999,6);	
			}
		}
		foreach (Employee item in employees) {
			Console.WriteLine(item);	
		}
	}
}
