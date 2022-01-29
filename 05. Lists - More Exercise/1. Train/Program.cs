using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] parts = command.Split();
                if (parts.Length == 2)
                {
                    int pasangers = int.Parse(parts[1]);
                    train.Add(pasangers);
                }
                else
                {
                    int pasangers = int.Parse(parts[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagon = train[i];
                        if (currentWagon + pasangers <= capacity)
                        {
                            train[i] += pasangers;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
