using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string evenNumbers = string.Empty;
            string oddNumbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int[] newArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenNumbers = $"{evenNumbers} {newArr[0]}";
                    oddNumbers = $"{oddNumbers} {newArr[1]}";
                }
                else
                {
                    evenNumbers = $"{evenNumbers} {newArr[1]}";
                    oddNumbers = $"{oddNumbers} {newArr[0]}";
                }
            }

            Console.WriteLine(evenNumbers.Trim());
            Console.WriteLine(oddNumbers.Trim());
        }
    }
}
