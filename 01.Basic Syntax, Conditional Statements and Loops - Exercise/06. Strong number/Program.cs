using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originNumber = number;
            int sum = 0;
            while (number>0)
            {
                int lastDigit = number % 10;
                int factoreal = 1;
                for (int i = lastDigit; i >= 1; i--)
                {
                    factoreal *= i;
                }

                sum += factoreal;
                number /= 10;
            }

            if (originNumber==sum)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }
    }
}
