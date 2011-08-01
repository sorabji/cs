using System;

using con = System.Console;

class Yards{
    public static void Main(){
        int length = 25,width = 42;
        double costPerSqYard = 3.00;

        double totalCost = ((length*width)/9)*costPerSqYard;
        con.WriteLine("the total cost is {0}.",totalCost.ToString("C"));
    }
}
