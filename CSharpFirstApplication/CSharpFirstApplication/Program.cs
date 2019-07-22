using System;

namespace CSharpFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer the following questions(each time pressing enter to continue):");

            Console.WriteLine("Question 1: What is the price of the home?");
            string homePrice = Console.ReadLine();

            Console.WriteLine("Question 2: What is your down payment?");
            string downPayment = Console.ReadLine();

            Console.WriteLine("Question 3: What is the interest rate (APR)?");
            string interestRate = Console.ReadLine();

            Console.WriteLine("You want to purchase a $" + homePrice + " home, with a down payment of $" + downPayment + " and an annual percentage rate of " + interestRate + "%.  Is that correct?  (Y/N)");
            Console.ReadLine();
        }
    }
}
