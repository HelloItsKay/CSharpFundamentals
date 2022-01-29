using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;


            for (int i = 1; i <= inputNumber; i++)
            {
                int water = int.Parse(Console.ReadLine());
                if (sum+water>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");

                }
                else
                {
                    sum += water;
                }
            }
            Console.WriteLine(sum);
        }

    }
}
