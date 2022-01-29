using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(GetSumOfEvenDigits(number));
        }

        static double GetSumOfEvenDigits(double num)
        {
            double evenSum = 0;
            for (int i = 0; i < num.ToString().Length; i++)
            {

                num %=10;
                if (num % 2 == 0)
                {
                    evenSum += num;
                }

                num /= 10;


            }
            return evenSum;
        }


    }
}
