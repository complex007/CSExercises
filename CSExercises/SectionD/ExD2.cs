using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.

    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int hcf = 0;
            int lcm = 0;

            CalculateHCFAndLCM(a, b, ref hcf, ref lcm);

            Console.WriteLine("HCF:" + hcf);
            Console.WriteLine("LCM:" + lcm);
        }

        public static void CalculateHCFAndLCM(int a, int b, ref int hcf, ref int lcm)
        {
            //YOUR CODE HERE
            //Don't worry about the use of "ref" keyword here. ref can be an input or output,but out can only be output.
            //At the end of the method, assign the HCF value to the hcf parameter
            //and LCM to the lcm parameter. hcf = <some value>; lcm=<some value>;
           

            int a1 = a;
            int b1 = b;
            int c;
            // int larger =Math.Max(a,b);
            do
            {
                if (a1 > b1)
                {
                    c = a1 - b1;
                    a1 = c;
                }
                else if (a1 < b1)
                {
                    c = b1 - a1;
                    b1 = c;
                }
            } while (a1 != b1);
    
            hcf = a1;
   

            lcm = (a * b) / hcf;
            
        }
    }
}
