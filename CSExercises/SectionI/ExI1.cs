using System;

namespace CSExercises
{
    //You are required to take as input an amount (dollar.cents).  
    //Assume that the amount is between 5 cents (inputted as 0.05) and 
    //3 dollars 50 cents (inputted as 3.50).  Further assume that we would 
    //always input nearest to 5 cents (i.e., values like 2.23 are not keyed in).  
    //The duty of your program is to dispense this amount (accurately!) using a combination of 
    //coins.  We have coins of denomination 100, 50, 20, 10 and 5 cents.  More than one coin of 
    //a denomination can be used.  
    //Yeah I know what you are thinking – simply issue all five cent coins; right?  
    //Cannot!- easy but no challenge.  
    //We are requesting the program to use the “minimum number of coins” principle.  
    //For example, if a request were made for 1.95 then the computer would issue one 100-cent coin, 
    //one 50-cent coin, two 20-cent coins and one 5-cent coin.  

    //The trick is to always start with the largest denomination and slowly go down.  
    //Try your luck – but don’t loose money!  

    public class ExI1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            
            //YOUR CODE HERE
            double num100 = Math.Floor(amount);   //100
            double num50 = Math.Floor((amount * 100 - num100 * 100) / 50.0); //50
            double num20 = Math.Floor((amount * 100 - num100 * 100 - num50 * 50) / 20.0);//20
            double num10 = Math.Floor((amount * 100 - num100 * 100 - num50 * 50-num20*20) / 10.0);//10
            double num5 = Math.Floor((amount * 100 - num100 * 100 - num50 * 50 - num20 * 20-num10*10) / 5.0);//5
            Console.WriteLine(num100);
            Console.WriteLine(num50);
            Console.WriteLine(num20);
            Console.WriteLine(num10);
            Console.WriteLine(num5);

        }
    }
}
