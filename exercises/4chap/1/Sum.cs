using System;
using con = System.Console;

class Sum {
    public static void Main (){
        /*int start=2,limit=100,count=0,length=2;

        for(int i = start; i<=limit; i++){
            if (start%2 == 0){
                con.Write(""+start+",");
                count++;
                if (count==length){
                    con.Write("\n");
                    length++;
                    count = 0;
                }
            }
            start++;
        }
        */

        double[] payRate = {3,6,3,77.5,3666,3.53};
        double sum = 0;
        foreach(double d in payRate){
            sum+=d;
            con.WriteLine("sum is " + sum);
        }



    }
}
