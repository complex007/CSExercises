using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string[] name = new string[5] { "John","Venkat","Mary","Victor","Betty"};
           int  [] mark = new int [5] { 63, 29, 75, 82, 55 };
            
           reportname(name) ;
           reportmark(mark);

        }
        public static void reportname(string[] name)
        {
            for(int i=0;i<name.Length;i++)
            {
                for (int j = i+1; j < name.Length ; j++ )
                    if (name[i].Substring(0, 1).CompareTo(name[j].Substring(0, 1)) == 1)
                    {
                        string c = name[j];
                        name[j] = name[i];
                        name[i] = c;
                        
                        
                    }

                Console.WriteLine(name[i]); 
            }
            
        }
        public static void reportmark(int[] mark)
        {
            for(int i=0;i<mark.Length;i++)
            {
                for (int j = i+1; j<mark.Length; j++)
                if(mark[i]<mark[j])
                {
                    int c = mark[i];
                    mark[i] = mark[j];
                    mark[j] = c;
                }
                Console.WriteLine(mark[i]); 
            }
            
        }
    }
}
