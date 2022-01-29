using System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNumber = bombNumbers[0];
                int currentNumber = numbers[i];


                if (currentNumber == bombNumber)
                {

                    for (int j = 1; j <= bombNumbers[1]; j++)
                    {
                        int leftIndex = i - j;
                        if (leftIndex < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[leftIndex] = 0;
                        }
                    }

                    for (int j = 1; j <= bombNumbers[1]; j++)
                    {
                        int rightIndex = i + j;
                        if (rightIndex > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[rightIndex] = 0;
                        }
                    }
                    numbers[i] = 0;
                }

            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);


        }
    }
}