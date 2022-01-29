using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            if (numb % 10 == 0)
            {
                Console.WriteLine($"The number is divisible by 10");
                return;
            }
            if (numb % 7 == 0)
            {
                Console.WriteLine($"The number is divisible by 7");
                return;
            }
            if (numb % 6 == 0)
            {
                Console.WriteLine($"The number is divisible by 6");
                return;
            }
            if (numb % 3 == 0)
            {
                Console.WriteLine($"The number is divisible by 3");
                return;
            }
            if (numb % 2 == 0)
            {
                Console.WriteLine($"The number is divisible by 2");
                return;
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }


        }
    }
}
