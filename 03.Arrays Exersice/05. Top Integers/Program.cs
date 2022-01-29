using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                for (int j = i + 1; j < arr.Length;)
                {
                    int rightNumber = arr[j];
                    if (number > rightNumber)
                    {
                        Console.Write($"{number} ");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"{arr[arr.Length - 1]}");
        }
    }
}
