using System;
using System.Linq;

namespace _1._Extract_Person_Information
{

    class Program
    {
        public static bool IsValid(string input)
        {
            return IsValidLenght(input) && ContainsValidSymbols(input);
        }


        private static bool IsValidLenght(string input)
        {
            return input.Length >= 3 && input.Length <= 16;
        }


        private static bool ContainsValidSymbols(string input)
        {
            foreach (char item in input)
            {
                if (!char.IsLetterOrDigit(item)
                    && item != '_'
                    && item != '-')
                {
                    return false;
                }

            }

            return true;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                if (IsValid(item))
                {
                    //Console.WriteLine(string.Join("",item));

                    Console.WriteLine(item);
                }

                Console.WriteLine(ContainsValidSymbols(item));
                Console.WriteLine(IsValidLenght(item));
            }

        }
    }
}
