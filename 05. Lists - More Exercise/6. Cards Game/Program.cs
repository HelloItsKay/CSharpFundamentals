using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                if (firstHand.Count == 0 || secondHand.Count == 0)
                {
                    break;
                }

                int first = firstHand[0];
                int second = secondHand[0];

                if (first > second)
                {
                    int tempNumber = firstHand[0];
                    firstHand.RemoveAt(0);
                    firstHand.Add(tempNumber);
                    firstHand.Add(secondHand[0]);
                    secondHand.RemoveAt(0);
                }
                else if (second> first)
                {
                    int temp = secondHand[0];
                    secondHand.RemoveAt(0);
                    secondHand.Add(temp);
                    secondHand.Add(firstHand[0]);
                    firstHand.RemoveAt(0);
                }
                else
                {

                    secondHand.RemoveAt(0);
                    firstHand.RemoveAt(0);
                }
            }

            if (firstHand.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }

        }
    }
}
