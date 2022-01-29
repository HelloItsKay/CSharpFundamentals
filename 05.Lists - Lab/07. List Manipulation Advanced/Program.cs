using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> command = new List<int>();

            bool isChanged = false;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "end")
                {
                    break;
                }
                string[] tokens = str.Split();

                switch (tokens[0])
                {
                        case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        isChanged = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        int numberToRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(numberToRemoveAt);
                        isChanged = true;
                        break;

                    case "Insert":
                        int numbToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numbToInsert);
                        isChanged = true;
                        break;
                    //------------------------------------------------------------------------------------------
                        case "Contains":
                        int numberToContain = int.Parse(tokens[1]);

                        if (numbers.Contains(numberToContain) == true)
                        {
                            Console.WriteLine($"Yes");
                        }
                        else
                        {
                            Console.WriteLine($"No such number");
                        }
                        break;

                    case "PrintEven": 
                         command = numbers.Where(x => x % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ",command));
                        break;

                    case "PrintOdd":
                         command = numbers.Where(x => x % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", command));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());

                        break;

                    case "Filter":
                        if (tokens[1]=="<")
                        {
                            command = numbers.Where(x => x < int.Parse(tokens[2])).ToList();
                        }
                        else if (tokens[1]==">")
                        {
                            command = numbers.Where(x => x > int.Parse(tokens[2])).ToList();
                        }
                        else if (tokens[1] == ">=")
                        {
                            command = numbers.Where(x => x >= int.Parse(tokens[2])).ToList();
                        }
                        else if (tokens[1] == "<=")
                        {
                            command = numbers.Where(x => x <= int.Parse(tokens[2])).ToList();
                        }
                        Console.WriteLine(string.Join(" ", command));
                        break;
                }

                if (isChanged==true)
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
            }
        }
    }
}
