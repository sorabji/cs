using System;
using con = System.Console;


class Calculate
{
    public static void Main ()
    {
    	double payRate=0, hours=0, grossPay=0, netPay=0, witholdingTax=0, lowTax=0, highTax=0;
    	
    	lowTax = 0.1;
    	highTax = 0.12;
  
    	con.WriteLine ("Enter your hourly payrate");
    	
		while (!double.TryParse (Console.ReadLine (), out payRate))
		{
    		con.WriteLine ("bad input!\n");
    		con.WriteLine ("Enter your hourly payrate");
    	}
  
		con.WriteLine ("Enter the amount of hours you worked");
  
		while (!double.TryParse (Console.ReadLine (), out hours))
		{
    		con.WriteLine ("bad input!\n");
    		con.WriteLine ("Enter the amount of hours you worked");
    	}
  
		grossPay = payRate * hours;
    	if (grossPay <= 300) 
		{
    		witholdingTax = grossPay * lowTax;
    	} else 
		{
			witholdingTax = grossPay * highTax;
		}
		
    	netPay = grossPay - witholdingTax;
		
		con.WriteLine("{0} hours worked, at {1} an hour.",hours,payRate.ToString("C"));
		con.WriteLine("gross pay is: {0}\nwithholding tax is: {1}\nnet pay is: {2}",
			grossPay.ToString("C"),
			witholdingTax.ToString("C"),
			netPay.ToString("C"));
    }
}
