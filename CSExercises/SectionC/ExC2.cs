using System;

namespace CSExercises
{
    //Write a program that would request for your name, 
    //gender and age and would print a greeting like this:
    //Good morning Uncle Sam( if Sam, M, 45 is entered)
    //(any gentlemen 40 years or more is Uncle any lady 
    //40 years or more is Aunty, if less than forty they 
    //become just Mr or Ms. as the case may be.)


    public class ExC2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            string gender="";
            do
            {
                Console.Write("Please enter your gender (M/F): ");
                gender = Console.ReadLine();
            }
            while (gender != "F" && gender != "M");

            Console.Write("Please enter your age: ");
            String input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            //YOUR CODE HERE
            string Addgender = "";

            if (gender == "F")
            { 
                if(age>=40)
                { Addgender = "Aunty"; }
                else
                { Addgender = "Ms. "; }
            }
            else if (gender == "M")
            {
                if (age >= 40)
                { Addgender = "Uncle"; }
                else
                { Addgender = "Mr. "; }
            }

            Console.WriteLine("Good morning {0} {1} . ", Addgender,name);
        }
    }
}