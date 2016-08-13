using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("pls enter x1:  ");
            string pointx1 = Console.ReadLine();
            Console.WriteLine("pls enter y1:  ");
            string pointy1 = Console.ReadLine();
            Console.WriteLine("pls enter x2:  ");
            string pointx2 = Console.ReadLine();
            Console.WriteLine("pls enter y2:  ");
            string pointy2 = Console.ReadLine();

            
            Console.WriteLine( CalculateDistance(Convert.ToDouble(pointx1), Convert.ToDouble(pointy1), Convert.ToDouble(pointx2), Convert.ToDouble(pointy2)));
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            return distance;
        }
    }
}
