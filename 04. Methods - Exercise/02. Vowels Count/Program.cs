using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCounter(str));
        }

        private static int VowelsCounter(string str)
        {
            int counter = 0;
            foreach (char letter in str)
            {
                if (letter == 'a' ||
                    letter == 'e' ||
                    letter == 'i' ||
                    letter == 'o' ||
                    letter == 'u' ||
                    letter == 'y')
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}

