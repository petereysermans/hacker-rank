using System;
using System.Globalization;

namespace HackerRank
{
    class Solution 
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Hackerrank ";

            // Declare second integer, double, and String variables.
            int intVar;
            double doubleVar;
            string stringVar;

            // Read and save an integer, double, and String to your variables.
            intVar = Int32.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            doubleVar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            stringVar = Console.ReadLine();
            
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(intVar + i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:0.0}", doubleVar + d);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + stringVar);
        }
    }
}
