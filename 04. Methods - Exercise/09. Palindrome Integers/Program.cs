using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Palindrome(input);
        }

        static void Palindrome(string str)
        {
            int reverse = 0;
            while (str != "END")
            {
                int number = int.Parse(str);
                int numberForComparison = number;

                while (number > 0)
                {
                    int reminder = number % 10;
                    reverse = reverse * 10 + reminder;
                    number = number / 10;
                }
                if (numberForComparison == reverse)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                reverse = 0;
                str = Console.ReadLine();
            }

        }
    }
}