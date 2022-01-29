using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int bestSequenceSize = 0;
            int bestSequenceStartingIndex = 0;
            int bestSequenceSum = 0;
            int[] BestSequence = new int[size];
            int bestSample = 1;
            int sample = 0;


            while (true)
            {
                string line = Console.ReadLine();
                sample += 1;
                if (line == "Clone them!")
                {
                    break; ;
                }

                int[] arr = line
               .Split('!', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

                int sequenceSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sequenceSum += arr[i];
                }



                for (int i = 0; i < arr.Length; i++)
                {
                    int currentNumber = arr[i];
                    if (currentNumber == 0)
                    {
                        continue;
                    }
                    int CurrentSequenceSize = 1;


                    for (int j = i + 1; j < arr.Length; j++)
                    {


                        if (currentNumber == arr[j])
                        {
                            CurrentSequenceSize += 1;
                        }
                        else
                        {
                            break;
                        }

                    }

                    if (CurrentSequenceSize > bestSequenceSize)
                    {
                        bestSequenceSize = CurrentSequenceSize;
                        bestSequenceStartingIndex = i;
                        bestSequenceSum = sequenceSum;
                        BestSequence = arr;
                        bestSample = sample;
                    }
                    else if (CurrentSequenceSize == bestSequenceSize)
                    {
                        if (i < bestSequenceStartingIndex)
                        {
                            bestSequenceSize = CurrentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            BestSequence = arr;
                            bestSample = sample;
                        }
                        else if (i == bestSequenceStartingIndex && sequenceSum > bestSequenceSum)
                        {
                            bestSequenceSize = CurrentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            BestSequence = arr;
                            bestSample = sample;
                        }
                    }


                }





            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ",BestSequence));



        }
    }
}
