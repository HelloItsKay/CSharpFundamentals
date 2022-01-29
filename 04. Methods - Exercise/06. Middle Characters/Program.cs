using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(str));
        }

        static string MiddleCharacter(string str)
        {
            if (str.Length % 2 == 0)

            {
                return $"{str[str.Length / 2 - 1]}{str[str.Length / 2]}";
            }

            return $"{str[(str.Length - 1)] / 2}";
        }
    }
}

