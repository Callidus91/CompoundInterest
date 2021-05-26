using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double Total = 0, amount, interestRate, years;
            Console.Write("Enter your investment amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your monthly interest rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            years = Convert.ToInt32(Console.ReadLine());

            for (int t = 1; t < years + 1; t++)
            {
                Total = amount * Math.Pow((1 + interestRate), years);
                Console.Write("Your Compound Interest Is: " + Total);
            }
            Console.ReadLine();
        }
    }
}
