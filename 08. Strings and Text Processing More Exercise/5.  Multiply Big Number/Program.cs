using System;
using System.Collections.Generic;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int reminder = 0;

            List<string> result = new List<string>();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';
                reminder += digit * multiplier;
                if (reminder > 9)
                {
                    int reminderLastDigit = reminder % 10;
                    reminder /= 10;
                    result.Add(reminderLastDigit.ToString());
                }
                else
                {
                    result.Add(reminder.ToString());
                    reminder = 0;
                }
            }

            if (multiplier == 0)
            {
                Console.WriteLine($"0");

            }
            else
            {
                if (reminder > 0)
                {
                    result.Add(reminder.ToString());
                }
                result.Reverse();
                Console.WriteLine(string.Concat(result));
            }

        }
    }
}
