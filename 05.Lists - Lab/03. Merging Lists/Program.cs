﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>(firstList.Count + secondList.Count);
            int limit = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < limit; i++)
            {
                numbers.Add(firstList[i]);
                numbers.Add(secondList[i]);
            }

            if (firstList.Count != secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    numbers.AddRange(GetRemindingList(firstList, secondList));
                }
                else
                {
                    numbers.AddRange(GetRemindingList(secondList, firstList));
                }
            }




            Console.WriteLine(string.Join(" ", numbers));

        }

        static List<int> GetRemindingList(List<int> longerList, List<int> shorterList)
        {
            if (longerList.Count <= shorterList.Count)
            {
                throw new ArgumentException();
            }
            List<int> result = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            return result;
        }


    }
}


