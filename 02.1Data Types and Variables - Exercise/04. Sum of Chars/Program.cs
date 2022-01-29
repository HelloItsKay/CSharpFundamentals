using System;
using System.Text;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= countChars; i++)
            {
                sum += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
