//using System;

namespace CSExercises
{
    public class ExH1
    {
        //public static void Main(
        //{
        //    string s1= Console.ReadLine();
        //    string s2= Console.ReadLine();


        //})
        public static bool InString(string s1, string s2)
        {
            //YOUR CODE HERE
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool judge = true;
            if (s1.Length >= s2.Length)
            {
                for (int i = 0; i < s1.Length - s2.Length; i++)
                {
                    if (s1.Substring(i, 1) == s2.Substring(0, 1))
                    {

                        if (s1.Substring(i, s2.Length) == s2)
                        {
                            judge = true;
                        }
                        else
                        {
                            judge = false;
                        }
                    }
                    
                }
            }
            else
            {
                judge = false;
            }
                return judge;
        }
    }
}
