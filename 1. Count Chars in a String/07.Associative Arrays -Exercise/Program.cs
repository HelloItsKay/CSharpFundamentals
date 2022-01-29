using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Associative_Arrays__Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<char, int > counts=new Dictionary<char, int>();
           string word = Console.ReadLine();
           foreach (var item in word)
           {
               if (item==' ')
               {
                   continue;
                   
               }

               if (counts.ContainsKey(item))
               {
                   counts[item]++;
               }
               else
               {
                   counts.Add(item,1);
               }
           }

           foreach (var item in counts)
           {
               Console.WriteLine($"{item.Key} -> {item.Value}");
           }
        }
    }
}
