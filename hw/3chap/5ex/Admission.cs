using System;
using con = System.Console;


class Calculate
{
    public static void Main ()
    {
        double gpa,testScore;
        string message = "";
    	con.WriteLine ("Enter your gpa");
    	
		while (!double.TryParse (Console.ReadLine (), out gpa))
		{
    		con.WriteLine ("bad input!\n");
    		con.WriteLine ("Enter your gpa");
    	}
  
		con.WriteLine ("Enter your test score");
  
		while (!double.TryParse (Console.ReadLine (), out testScore))
		{
    		con.WriteLine ("bad input!\n");
    		con.WriteLine ("Enter your test score");
    	}

        if ((gpa >= 3.0 && testScore >=60)||(gpa < 3.0 && testScore >= 80)){
            message = "Accepted";
        } else {
            message = "Rejected";
        }
        con.WriteLine("result is: {0}",message);
    }
}
