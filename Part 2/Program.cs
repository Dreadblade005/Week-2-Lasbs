/// File Name: MyFirstProgram.java
/// @author: Dakota Durst
/// Date:  September 3rd, 2020
///
/// Problem Statement: Take a number of coupons and divide them among candy and gumballs
/// 
/// 
/// Overall Plan:
/// 1) assign variables: coupons, cost of candy/gum, coupins after candy/gum
/// 2) take coupons and divide coupons by cost of gum
/// 3) assign the value of quotient to the number of candy bars, take remainder as new number of currently held coupons
/// 4) repeat step 3 with gum instead of candy
/// 5) print out amount of candy bars, gum, and remaining coupons



using System;
using System.Runtime.ExceptionServices;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int num_coupons = 108;
            int num_coupons_after_candy = 0;
            int num_coupons_after_gum = 0;
            int num_candy_bars = 0;
            int num_gumballs = 0;

            ///Processing
            num_candy_bars = num_coupons / 10;
            //System.out.println("Number candy bars: " + num_candy_bars);
            //calculate remaining bars
            num_coupons_after_candy = num_coupons % 10;
            ////System.out.println("Number of coupons after candy: " + num_coupons_after_candy);
            //calculate gumballs;
            num_gumballs = num_coupons_after_candy / 3;
            //calculate remaining coupons 
            num_coupons_after_gum = num_coupons_after_candy % 3;


            ///output
            Console.WriteLine("Your " + num_coupons + " coupons can be redeemed for " + num_candy_bars + " candy bars and " + num_gumballs +
            " gumballs with " + num_coupons_after_gum + " coupons remaining.");







        }
    }
}
