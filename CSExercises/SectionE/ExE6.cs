using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can use ExE4.IsPerfectNumber() method here
            for(int n=1;n<=1000;n++)
            {
               if( ExE4.IsPerfectNumber(n))
               {
                   Console.WriteLine(n);
               }
            }


        }
    }
}
