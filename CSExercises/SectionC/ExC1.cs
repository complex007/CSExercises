using System;

namespace CSExercises
{
    //Write a program that would request for your name and gender (M or F assume capital letter) and print a greeting like this:
    //Good Morning Mr.Venkat
    //where you entered Venkat for name and M for gender.

    public class ExC1
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            string gender = "";
            do
            {
                Console.Write("Pls enter your gender (M/F) : ");
                gender = Console.ReadLine();
            }
            while (gender != "M" && gender != "F");
           
            ////bool result = Convert.ToBoolean(gender);
            ////result = true;

            ////YOUR CODE HERE
            string Gender ="";
            if (gender == "M")
            { Gender = "Mr. "; }
            else if (gender == "F")
            { Gender = "Ms. "; }
            
            
             //     Console.Write("Pls enter your gender (M/F) : ");
             //     gender = Console.ReadLine();
             //} 
            

            
            Console.WriteLine("Good Morning {0} {1} .",Gender,name);            
        }
        //public static void Getgender()
        //{
        //    Console.Write("Pls enter your gender (M/F) : ");
        //    string genderstr = Console.ReadLine();
        //  if(genderstr =="M"|| genderstr =="F")
        //  {
        //      gender=
        //  }

        //}
        
    }
}