using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            foreach (string firstElement in arr2)
            {
                foreach (string secondElement in arr1)
                {
                    if (firstElement==secondElement)
                    {
                        Console.Write($"{firstElement} ");
                    }
                }
            }
         
        }
    }
}
