using System;

namespace CSExercises
{
    //Write a program for the following:
    //a.Declare an array of dimension 10 (index 0… 9). 
    //b.Generate 50 Random integers in the range 0 … 9.
    //c.Store the number of occurrences(count) in the array appropriately.
    //d.Print a table that would list the numbers and the number of occurrences.

    //Addition:
    //-	Try to print an histogram for the above
    //-	How would the program be affected if the range of numbers randomly generated is between -5 and +5?

    // Sample Output
    // Number Count
    //  0		  4
    //  1		  2
    //  2		  8
    //  3		  6
    //  4		  5
    //  5		  5
    //  6		 11
    //  7		  0
    //  8		  3
    //  9		  6

    //Number	
    //  0	****  
    //  1	**
    //  2	********
    //  3	******
    //  4	*****
    //  5	*****
    //  6	***********
    //  7	
    //  8	***
    //  9	******

    public class ExI2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            int[] number = new int[10]{0,1,2,3,4,5,6,7,8,9};
            int[] checknum = new int[50];
            int[] countnum = new int[10];
            string[] histogram= new string[10];
            getrandom(ref checknum);
            countnum = getcount(number, checknum);
            Print1(number, countnum);
            Print2(countnum, histogram, number);
            
           



        }
        public static void getrandom(ref int[] randomnum)
        {
            Random s = new Random();
            for (int i = 0; i < 50; i++)
            {


                randomnum[i] = s.Next(0, 9);


            }

        }
        public static int[] getcount(int[] a,int[] b)
        {
            int[] count = new int[10];
            {
                for(int i=0;i<a.Length;i++)
                {
                    for(int j=0;j<b.Length;j++)
                    {
                        if(a[i]==b[j])
                        {
                            count[i] = count[i] + 1;
                        }
                    }
                }
            }
            return count;
        }
        public static void Print1(int[] number,int[] countnum)

        {
            Console.WriteLine("Number      Count");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("{0}           {1}", number[i], countnum[i]);
            }
        }
        public static void Print2(int[] countnum, string[] histogram, int[] number)
        {
            string[] s = new string[10]{"","","","","","","","","",""};
            for (int i = 0; i < 10; i++)
            {
                //// do { histogram[i] = histogram[i] + "*"; } while (histogram[i].Length < checknum[i]-1);

                s[i] = s[i].PadLeft(countnum[i], '*');
                histogram[i] =s[i];

            }


            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0}           {1}", number[j], histogram[j]);
            }
        }
    }
}
