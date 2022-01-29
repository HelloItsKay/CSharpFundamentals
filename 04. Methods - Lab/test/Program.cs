using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int currDigit = 0;
            int sum = 0;
            while (num > 0)
            {
                currDigit = num % 10;

                if (currDigit % 2 == 0)

                    sum = sum + currDigit;

                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
