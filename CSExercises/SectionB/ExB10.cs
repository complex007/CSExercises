using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("pls enter a:  ");
            string sideAstr = Console.ReadLine();
            Console.WriteLine("pls enter b:  ");
            string sideBstr = Console.ReadLine();
            Console.WriteLine("pls enter c:  ");
            string sideCstr = Console.ReadLine();

            double SideA=Convert.ToDouble(sideAstr);
            double SideB=Convert.ToDouble(sideBstr);
            double SideC=Convert.ToDouble(sideCstr);
            double num = (SideA + SideB + SideC) / 2;

            if (num *(num-SideA)*(num-SideB)*(num- SideC)<0)
            {
                string note = "can't be computed";
                Console.WriteLine(note);
            }
            else
            {
                Console.WriteLine(CalculateArea(SideA,SideB,SideC));
            }


        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;     
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;          
        }
    }
}