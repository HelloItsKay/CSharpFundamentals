using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<string> guesList = new List<string>();
            for (int i = 0; i < counter; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split();

                string name = parts[0];

                if (parts.Length == 4)
                {
                    bool removed = guesList.Remove(name);
                    if (!removed)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                }
                else
                {
                    if (guesList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guesList.Add(name);
                    }
                }

            }
            foreach (var guest in guesList)
            {
                Console.WriteLine(guest);
            }

        }
    }
}
