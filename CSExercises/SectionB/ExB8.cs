using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string input = Console.ReadLine();

            Console.WriteLine("{0:0.00}",CalculateFare(Convert.ToDouble(input)));

        }

        public static double CalculateFare(double distance)
        {
            //your code here
            double fare = 2.40 + distance * 0.4;
            double result = Math.Round(fare, 1);
            return result;

        }
    }
}
