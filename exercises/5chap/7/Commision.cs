using System;
using con = System.Console;

class Commission {
    public static void Main (string[] args){
        double[] ranges = {0,15000.01,24000.01};
        double[] commission = {.05,.07,.1};
        double input;
        int sub = 2;

        con.WriteLine("enter the price paid for car");

        while(!Double.TryParse(con.ReadLine(),out input)){
            con.WriteLine("bad input");
            con.WriteLine("enter the price paid for car");
        }

        while (sub >=0 && input < ranges[sub]){
            sub--;
        }
        double finalCommission = input*commission[sub];
        con.WriteLine("commission charged is {0}\nprice for car is {1}\ntotal commission is {2}",
                commission[sub].ToString("p"),
                input.ToString("c"),
                finalCommission.ToString("c"));
    }
}
