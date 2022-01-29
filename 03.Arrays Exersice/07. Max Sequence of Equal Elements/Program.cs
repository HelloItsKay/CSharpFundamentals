using System;
using System.Drawing;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int BestSiquence = 0;
            int BestSiquenceNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int siquenceSize = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];
                    if (currentNumber == rightNumber)
                    {
                        siquenceSize += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (siquenceSize > BestSiquence)
                {
                    BestSiquence = siquenceSize;
                    BestSiquenceNumber = currentNumber;
                }




            }

            for (int i = 0; i < BestSiquence; i++)
            {
                Console.Write($"{BestSiquenceNumber} ");
            }

        }
    }
}
