using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string input = Console.ReadLine();

            Console.WriteLine( CalculateFare(Convert.ToDouble(input)));
            //int a = 5;
            //Console.WriteLine(a++);
            //Console.WriteLine(a++);
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
          
            double fare = 2.40 + distance * 0.4;

            return (Math.Ceiling(fare*10))/10;
            

        }
    }
}
