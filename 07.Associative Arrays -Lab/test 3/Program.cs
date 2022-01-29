using System;
using System.Linq;
using System.Collections.Generic;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (true)
            {
                string[] token = input.Split();

                if (token[0] == "Stop")
                {
                    break;
                }

                if (token[0] == "Delete")
                {
                    int index = int.Parse(token[1]);

                    if (int.Parse(token[1]) >= -1 && int.Parse(token[1]) < text.Count - 1)
                    {
                        for (int i = 0; i < text.Count; i++)
                        {
                            if (index == i)
                            {
                                text.RemoveAt(i + 1);
                            }
                        }
                    }
                }
                else if (token[0] == "Swap")
                {
                    if (text.Contains(token[1]) && text.Contains(token[2]))
                    {
                        for (int i = 0; i < text.Count; i++)
                        {
                            if (text[i] == token[1])
                            {
                                text[i] = token[2];
                            }
                            else if (text[i] == token[2])
                            {
                                text[i] = token[1];
                            }
                        }
                    }
                }
                else if (token[0] == "Put")
                {
                    string word = token[1];
                    int index = int.Parse(token[2]) - 1;

                    if (text.Count >= index && index >= 0)
                    {
                        text.Insert(index, word);
                    }
                }
                else if (token[0] == "Sort")
                {
                    text.Sort();
                    text.Reverse();
                }
                else if (token[0] == "Replace")
                {
                    if (text.Contains(token[2]))
                    {
                        for (int i = 0; i < text.Count; i++)
                        {
                            if (text[i] == token[2])
                            {
                                text[i] = token[1];
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", text));

        }
    }
}