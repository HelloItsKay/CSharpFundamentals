using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ")
                .ToList();
            int a = 0;
            int b = 3;

            input = Merge(input, a, b);

            Divide(input, a, b);
        }
        static List<string> Merge(List<string> theList, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > theList.Count - 1)
            {
                endIndex = theList.Count - 1;
            }


            for (int i = startIndex; i < endIndex; i++)
            {
                theList[startIndex + 1] = theList[startIndex] + theList[startIndex + 1];
                theList.RemoveAt(startIndex+1);
            }
            return theList;


        }

        static void Divide(List<string> theList, int index, int partitions)
        {

            if (theList[index].Length % partitions == 0)
            {
                List<string> tempList = new List<string>();
                string temp = theList[index];
                string result = string.Empty;
                for (int i = temp.Length + 1; i >= 0; i = i - 2)
                {
                    result = temp[i].ToString();
                    result += temp[i + 1].ToString();
                    tempList.Add(result);
                    theList.Insert(0, result);
                    result = string.Empty;
                }

                Console.WriteLine(string.Join(" ", theList));
            }
        }


    }
}