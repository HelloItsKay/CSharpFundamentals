using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (input[0] == "Stop")
                {

                    break;
                }

                if (input[0] == "Swap")
                {
                    Swap(words, input[1], input[2]);
                }

                else if (input[0] == "Delete")
                {
                    Delete(words, int.Parse(input[1]));
                }
                else if (input[0] == "Put")
                {
                    Put(words, input[1], int.Parse(input[2]) - 1);
                }
                else if (input[0] == "Sort")
                {
                    Sort(words);
                }
                else if (input[0] == "Replace")
                {
                    Replace(words, input[1], input[2]);
                }
            }

            Console.WriteLine(string.Join(" ", words));

        }

        static void Delete(List<string> theList, int index)
        {
            if (index + 1 <= theList.Count)
            {
                theList.RemoveAt(index + 1);
            }
        }

        static void Swap(List<string> theList, string word1, string word2)
        {
            if (theList.Contains(word1) && theList.Contains(word2))
            {
                for (int i = 0; i < theList.Count; i++)
                {
                    if (theList[i] == word2)
                    {
                        theList[i] = word1;
                        continue;
                    }

                    if (theList[i] == word1)
                    {
                        theList[i] = word2;
                    }
                }
            }
        }

        static void Put(List<string> theList, string word, int index)
        {
            if (index >= 0 && index <= theList.Count)
            {
                theList.Insert(index, word);
            }
        }

        static void Sort(List<string> theList)
        {
            theList.Sort();
            theList.Reverse();
        }

        static void Replace(List<string> theList, string word1, string word2)
        {
            if (theList.Contains(word2))
            {
                for (int i = 0; i < theList.Count; i++)
                {


                    if (theList[i] == word2)
                    {
                        theList[i] = word1;
                    }

                }
            }
        }

    }
}
