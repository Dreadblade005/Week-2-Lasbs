/// Week 2		Lab No. 1
/// File Name: MyFirstProgram.java
/// @author: Dakota Durst
/// Date:  September 3rd, 2020
///
/// Problem Statement: Ask the user to enter three numbers, calculate the sum of
/// these numbers, and display the sum to the screen
/// 
/// 
/// Overall Plan:
/// 1) Edit message to commadate extra integer
/// 2) create 3 integers and sum
/// 3) get user input 3 seperate times to get 3 variables
/// 4) take 3 numbers and add them together, display result
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, and then lastly enter a third number and press enter:");

            // declare all integer variables
            int n1, n2, n3, sum; 
            double do_math, times;


            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());


            // calculate the sum, product, and percentage of these two numbers
            sum = n1 + n2 + n3;
            times = n1 * n2 * n3; 
            do_math = sum / times;

            // print a message to make sure the math is correct
            Console.WriteLine("The sum of those three numbers is: " + sum);
            Console.WriteLine("The product of those three numbers is: " + times);
            Console.WriteLine("The sum divided by the product is equal to: " + do_math);



            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}