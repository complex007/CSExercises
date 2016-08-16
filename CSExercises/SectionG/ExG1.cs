using System;
using System.Linq;

namespace CSExercises
{
    //Program to count the number of vowels in a given phrase and print out 
    //the number of each vowel. (a, e, i, o & u are vowels)
    //a.Write a program to read a phrase from the console and count the number 
    //of vowels there are in the phrase.You should substring one character at a time and 
    //match it to the vowels and increment the counter.
    //b.Make your program explicitly count the number of occurrences of each vowel 
    //ie: number of a’s, number of e’s etc.)

    public class ExG1
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static void Main(string[] args)
        {

            Console.Write("Please enter a phrase: ");
            string phrase = (Console.ReadLine()).ToLower();

            Console.WriteLine("Total number of vowels: " + CountVowels(phrase));

            int[] vowelCount = CountIndividualVowels(phrase);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}", vowels[i], vowelCount[i]);
            }
        }

        public static int CountVowels(string phrase)
        {
            //YOUR CODE HERE
            int sum = 0;
            for (int i = 0; i < phrase.Length; i++ )
            {
                
                for( int j=0; j<vowels.Length;j++)
                {
                    string input=phrase.Substring(i,1);
                    string compare = Convert.ToString(vowels[j]);

                    if(input.Equals(compare))
                    {
                        sum = sum + 1;
                    }
                }

            }
                return sum;


        }

        public static int[] CountIndividualVowels(string phrase)
        {
            int[] vowelCount = new int[5] { 0, 0, 0, 0, 0 };
            //YOUR CODE HERE
            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < phrase.Length; j++)
                {


                    string input = phrase.Substring(j, 1);
                    string compare = Convert.ToString(vowels[i]);

                    if (input.Equals(compare))
                    {
                        vowelCount[i] = vowelCount[i] + 1;


                    }
                }

            }
            return vowelCount;
        }
            public static void judge(string phrase)
            {
                         for (int i = 0; i < phrase.Length; i++ )
                    {
                
                        for( int j=0; j<vowels.Length;j++)
                        {
                            string input=phrase.Substring(i,1);
                            string compare = Convert.ToString(vowels[j]);
                        }
                    }

            
        }
    }
}
