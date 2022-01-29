using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
         Dictionary<string,int> quantityByResource=new Dictionary<string, int>();

         while (true)
         {
             string input = Console.ReadLine();
             if (input=="stop")
             {
                 break;
             }

             int quantity = int.Parse(Console.ReadLine());
             if (quantityByResource.ContainsKey(input))
             {
                 quantityByResource[input] += quantity;
             }
             else
             {
                 quantityByResource.Add(input,quantity);
             }
         }

         foreach (var element in quantityByResource)
         {
             Console.WriteLine($"{element.Key} -> {element.Value}");
         }
        }
    }
}
