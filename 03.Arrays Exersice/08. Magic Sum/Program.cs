using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int firstNumber = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    int secondNumber = arr[j];
                    if (firstNumber+secondNumber==magicNumber)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                    }
                }

            }

        }
    }
}
