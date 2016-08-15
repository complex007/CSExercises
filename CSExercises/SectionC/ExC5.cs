using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Please enter a three_digit integer:   ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsArmstrongNumber(num))
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
            

        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            double number= Convert.ToDouble(n);
            double num1 =Math.Floor(number / 100);
            double num2 = Math.Floor((number - num1 * 100) / 10);
            double num3 =number - num1 * 100-num2*10;
            bool judgeresult;

            if (number==Math.Pow(num1,3)+Math.Pow(num2,3)+Math.Pow(num3,3))
            { judgeresult = true;
            
            }
            else
            { judgeresult = false;
           
            }

            //Console.WriteLine(num1);

            //Console.WriteLine(num2);

            //Console.WriteLine(num3);

            //Console.WriteLine(Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3));

            return judgeresult;

        }
    }
}