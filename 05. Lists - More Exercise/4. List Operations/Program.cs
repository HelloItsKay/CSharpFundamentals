using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Add")
                {
                    int number = int.Parse(parts[1]);
                    numbers.Add(number);
                }

                else if (command == "Insert")
                {
                    int number = int.Parse(parts[1]);
                    int index = int.Parse(parts[2]);

                    if (!IsValid(index, numbers))
                    {
                        Console.WriteLine("Invalid index");
                        continue;

                    }
                    numbers.Insert(index, number);
                }

                else if (command == "Remove")
                {
                    int index = int.Parse(parts[1]);

                    if (!IsValid(index, numbers))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }

                else if (command == "Shift")
                {
                    string direction = parts[1];
                    int count = int.Parse(parts[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstElement = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstElement);
                        }

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastElement = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count-1);
                            numbers.Insert(0,lastElement);
                        }

                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsValid(in int index, List<int> numbers)
        {
            return index >= 0 && index < numbers.Count;
        }
    }
}
