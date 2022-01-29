using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine((CalculateFactoriel(first)/CalculateFactoriel(second)).ToString("0.00"));
        }

        static double CalculateFactoriel(double a)


        {
            double result = 1;
            for (int i = 2; i <=a; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
