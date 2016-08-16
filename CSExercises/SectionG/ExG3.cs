using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string[] s=phrase.Split(' ');
            string result = "";
            

            for (int i = 0; i < s.Length;i++ )
            {
                string r= s[i].Substring(0, 1).ToUpper();
                string h = "";
                if(s[i].Length==0)
                {
                    h = "";  
                }
                else
                {
                    h = s[i].Substring(1, s[i].Length-1).ToLower();
                }
                

                result = result + r + h + " ";
            }
                return result;


        }
    }
}
