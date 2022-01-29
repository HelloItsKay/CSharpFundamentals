using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SignCheker(num));
        }

        static string SignCheker(int number)
        {
            string result = String.Empty;

            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }

            return ($"The number {number} is {result}.");
        }
    }
}
