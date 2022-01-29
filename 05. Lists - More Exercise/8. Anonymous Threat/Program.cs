using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (true)
            {

                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "3:1")
                {
                    Console.Write(string.Join(" ", words));
                    break;
                }

                else if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    Merge(words, startIndex, endIndex);
                }

                else if (input[0] == "divide")
                {
                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);
                    Divide(words, index, partitions);
                }
            }

            static void Merge(List<string> input, int startIndex, int endIndex)

            {
                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex > input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }

                for (int j = startIndex + 1; j <= endIndex; j++)
                {
                    input[startIndex] += input[startIndex + 1];
                    input.RemoveAt(startIndex + 1);
                }

            }
            static void Divide(List<string> input, int index, int partitions)
            {
                string partitionData = input[index];
                input.RemoveAt(index);
                int partSize = partitionData.Length / partitions;
                int reminder = partitionData.Length % partitions;

                List<string> tmpData = new List<string>();

                for (int i = 0; i < partitions; i++)
                {
                    string tmpString = null;

                    for (int p = 0; p < partSize; p++)
                    {
                        tmpString += partitionData[(i * partSize) + p];
                    }

                    if (i == partitions - 1 && reminder != 0)
                    {
                        tmpString += partitionData.Substring(partitionData.Length - reminder);
                    }

                    tmpData.Add(tmpString);
                }

                input.InsertRange(index, tmpData);


            }
        }
    }
}
