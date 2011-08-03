using System;
using con = System.Console;

class CheckZip {
    public static void Main (string[] args){
        int[] zips = new int[10];
        int curZip = 92020,input;
        bool flag = false;
        for(int i=0; i<zips.Length; i++){
            zips[i] = curZip;
            curZip += 2;
        }
        con.WriteLine("please enter a 5 digit zipcode");
        while(!int.TryParse(con.ReadLine(),out input)){
            con.WriteLine("bad input");
            con.WriteLine("please enter a 5 digit zipcode");
        }
        foreach(int i in zips){
            if (i==input){
                flag = true;
            }
        }
        if (flag){
            con.WriteLine("we deliver");
        } else {
            con.WriteLine("don't deliver");
        }
    }
}
