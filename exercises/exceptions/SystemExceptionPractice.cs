using System;

class SystemExceptionPractice
{
    public static void Main (String [] args)
    {
        int i = 0;
        try
        {
        Console.WriteLine(5/i);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine(e.GetType());
        }
    }
}
