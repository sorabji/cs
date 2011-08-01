using System;
using con = System.Console;

class Eggs{
    public static void Main(){
        int c1 = 34,c2 = 43,c3 = 13,c4 = 13;
        int totalEggs = c1+c2+c3+c4;
        int totalSingleEggs = totalEggs%12;
        int dozens = (totalEggs-totalSingleEggs)/12;

        con.WriteLine("{0} total eggs gives {1} dozen and {2} eggs.",totalEggs,dozens,totalSingleEggs);
    }
}
