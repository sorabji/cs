using System;

namespace FSQ{
    class FindSquareRoot{
    	public static void Main(String[] argv){
    		double number=0,sqrt=0;
			
			Console.Write("enter a number\n$  ");
			
			try {
				number=Double.Parse(Console.ReadLine());
				if (number < 0) {
					throw new ApplicationException("Number can't be negative");	
				}
				sqrt=Math.Sqrt(number);
				Console.WriteLine("the square root of {0} is: {1}",number,sqrt);
			} catch (FormatException ex) {
				Console.WriteLine("The input should be a number");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
				sqrt=0;
			} catch (ApplicationException ex){
				Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
				sqrt=0;
			}
			
		}
    }
}
