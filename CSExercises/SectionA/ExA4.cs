﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes a double precision number as input 
    //and prints the square of that number
    //For this exercise, you need to implement the square function
    //and handle the input and output in the Main method (use Exercise 2 as an example)

    public class ExA4
    {
        public static void Main(string[] args)
        {
            //PUT YOUR CODE HERE 
            string inputStri = Console.ReadLine();
            double number = Convert.ToDouble(inputStri);
            double result = square(number);
            Console.WriteLine("{0:###.00}",result);

        }

        public static double square(double x)
        {
            //PUT YOUR CODE HERE
            double y = x * x;
            return y;

        }
    }
}
