using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.WriteLine("the number of TV: ");
            int numTV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number of DVD: ");
            int numDVD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number of MP3: ");
            int numMP3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Discounted Price : {0}",CalculateTotalPrice(numTV,numDVD,numMP3));


        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            
            double resultTV=tvQty*900;
            double resultDVD=dvdQty*500;
            double resultMP3=mp3Qty*700;
            double a=1 ;
           

            Console.WriteLine("{0},{1},{2}",resultTV, resultDVD, resultMP3);


            double result=resultDVD+resultMP3+resultTV;

            if (result > 10000)
            {
                a = 0.85;
            }
            else
            {
                if (result > 5000)
                {
                    a = 0.9;
                }
            }
            Console.WriteLine("{0}", a);

            return (a*(resultDVD+resultTV)+resultMP3 );



        }
    }
}