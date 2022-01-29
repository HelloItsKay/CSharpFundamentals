using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RiseToPower(a,b));
        }

        static double RiseToPower(double number, double power)
        {
            double result = 0;
            double result2 = 0;
            for (int i = 1; i <= power; i++)
            {
                result = Math.Pow(number, power);

            }

            return result;

        }
    }
}
