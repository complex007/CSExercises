using System;
namespace CSExercises
{

    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.
        public static string Hex(int i)
        {
            //YOUR CODE HERE
            int input=i;
            
            string result = "";
            int a;
            string sum = "";
               
            if (input <= 9)
            {
                result = Convert.ToString(input);
            }
            else if (input < 16)
            {
                string[] lessthan = new string[6] { "A", "B", "C", "D", "E", "F" };
                result = Convert.ToString(lessthan[input - 10]);
            }
            else
            {
                do
                {
                    a = input % 16;
                            
                            
                    if (a <= 9)
                    {
                        result =Convert.ToString(a);
                    }
                    else if (a < 16)
                    {
                        string[] lessthan = new string[6] { "A", "B", "C", "D", "E", "F" };
                        result =Convert.ToString(lessthan[a - 10]);
                    }
                            
                        sum=  result + sum;

                    input =input/16;

                } while (input > 0);
                result = sum;
            }

               

                
                

            
            return result;






        }
    }
}
