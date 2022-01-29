using System;

namespace _8.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];


                double number = double.Parse(item.Substring(1, item.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - 64;
                }
                else
                {
                    number *= firstLetter - 96;
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - 64;
                }
                else
                {
                    number += lastLetter - 96;
                }

                result += number;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
