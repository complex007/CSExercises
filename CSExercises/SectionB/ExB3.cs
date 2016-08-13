using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string input = Console.ReadLine();
           Console.WriteLine( CalculateIncome(input));
         

        }

        public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            double salary = Convert.ToDouble(salaryStr);

            double housing = 0.1 * salary;
            double transport = 0.03 * salary;
            double income = salary + housing + transport;
            //string result = String.Format("${0:#,##0.00}",income);
            string result = String.Format("{0:c}", income);
            return result ;
        }
    }
}
