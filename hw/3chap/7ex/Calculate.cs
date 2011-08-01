using System;
using con = System.Console;


class Calculate
{
    public static void Main ()
    {
        int int1 = 0, int2 = 0, result=0;
        char char1 = 'a';
        bool flag = false;
        string oper = "";

        con.Write("Enter a number\n");

        while (!Int32.TryParse (Console.ReadLine (), out int1)){

            con.WriteLine ("bad input!\n");
            con.WriteLine ("Enter a number");
        }
  
        con.WriteLine ("Enter another number");
  
        while (!Int32.TryParse (Console.ReadLine (), out int2))
        {
            con.WriteLine ("bad input!\n");
            con.WriteLine ("Enter another number");
        }

        con.WriteLine ("Enter a single character");

        while (!Char.TryParse (Console.ReadLine (), out char1))
        {
            con.WriteLine ("bad input!\n");
            con.WriteLine ("Enter a single character");
        }

        switch (char1){
            case 'A':
                result = int1+int2;
                oper = "addition";
                flag = true;
                break;
            case 'S':
                result = int1-int2;
                oper = "subtraction";
                flag = true;
                break;
            case 'M':
                result = int1*int2;
                oper = "multiplication";
                flag = true;
                break;
            default:
                flag = false;
                break;
        }
        if (flag){
            con.WriteLine ("You chose: {0}\nResult: {1}",oper,result.ToString());
        } else {
            con.WriteLine ("The character you entered matched no operations. (try 'A','M', or 'S' next time)");
        }
    }
}
