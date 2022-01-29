using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatings = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStrings(input,repeatings));
        }

        static string RepeatStrings(string str, int count)
        {
            for (int i = 0; i <count; i++)
            {
                Console.Write(str);
            }
            return String.Empty;
        }
    }
}
