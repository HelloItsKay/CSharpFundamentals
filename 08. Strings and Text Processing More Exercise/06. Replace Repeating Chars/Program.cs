using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousSymbol = '\0';
            StringBuilder result = new StringBuilder();
            foreach (var item in input)
            {
                if (item!=previousSymbol)
                {
                    result.Append(item);
                }

                previousSymbol = item;
            }

            Console.WriteLine(result);



        }
    }
}
