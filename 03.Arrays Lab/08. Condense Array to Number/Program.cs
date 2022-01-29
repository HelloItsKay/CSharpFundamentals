using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int condensed = arr.Length;

            while (condensed>1)
            {
                for (int i = 0; i < arr.Length-1; i++)
                {
                    arr[i] = arr[i] + arr[i + 1];
                }

                condensed--;
            }

            Console.WriteLine(arr[0]);
        }
    }
}   
