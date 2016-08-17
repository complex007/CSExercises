using System;
namespace CSExercises
{
    //Write a static method:  Substitute(string s, char c1, char c2) that would 
    //return a string. The method should find all occurrences of the character c1 
    //in the string s and substitute c1 with character c2.  The new word so formed would 
    //be the return value of this method. 
    public class ExH4
    {
        public static string Substitute(string s, char c1, char c2)
        {
            //YOUR CODE HERE
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {


                if (s.Substring(i, 1).Equals(Convert.ToString(c1)))
                {
                    result = result + Convert.ToString(c2);
                }
                else
                {
                    result = result + s.Substring(i, 1);
                }
            }

            return result;

        } 
        
    }
 }

