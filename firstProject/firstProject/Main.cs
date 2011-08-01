using System;
// aliasing
using con = System.Console;

namespace firstProject{
	class MainClass{
		public static void Main (string[] args){
			int a,b;
			if (args.Length > 0){
				try{
					a = Int32.Parse(args[0]);
					b = Int32.Parse(args[1]);
					int sum = a+b;
					con.WriteLine("the sum is: "+sum);
				}
				catch(FormatException e){
					con.WriteLine("bad input! "+e);
				}
			} else {
				con.WriteLine("you didn't enter any numbers");
			}
			con.WriteLine("Please enter the cost of the book");
			double cost = Double.Parse(con.ReadLine());
		
			con.WriteLine("Please enter the number of books to buy");
			int number = Int32.Parse(con.ReadLine());
			
			con.WriteLine("{0} books cost {1}.",number,(number*cost).ToString("C"));
		}
	}
}

