using System;
using con = System.Console;


class IQ
{
    public static void Main ()
    {
        double iqScore;
        string[] messages = {"error message","above average","average","below average"};
        string response = "";
    	con.WriteLine ("Enter your iq score");
    	
		while (!double.TryParse (Console.ReadLine (), out iqScore))
		{
    		con.WriteLine ("bad input!\n");
    		con.WriteLine ("Enter your iq score");
    	}

        if (iqScore < 0 || iqScore > 200 )
        {
            response = messages[0];
        } else if ( iqScore > 100 )
        {
            response = messages[1];
        } else if ( iqScore == 100 )
        {
            response = messages[2];
        } else if ( iqScore < 100 )
        {
            response = messages[3];
        }

        con.WriteLine("iq score of: {0}\nresult is: {1}",iqScore.ToString(),response);
    }
}
