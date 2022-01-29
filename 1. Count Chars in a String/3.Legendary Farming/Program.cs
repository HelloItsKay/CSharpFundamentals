using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>
                {
                    {"shards",0},
                    {"fragments",0},
                    {"motes",0},
                };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isRunning = true;
            string winnerItem = "";
            while (isRunning)
            {
                string[] parts = Console.ReadLine().Split();
                for (int i = 0; i < parts.Length; i += 2)
                {
                    int quantity = int.Parse(parts[i]);
                    string item = parts[i + 1].ToLower();

                    if (legendaryItems.ContainsKey(item))
                    {
                        legendaryItems[item] += quantity;
                        if (legendaryItems[item] >= 250)
                        {
                            winnerItem = item;
                            legendaryItems[item] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else
                    {
                        junk.Add(item, quantity);
                    }
                }
            }
            if (winnerItem == "shards")
            {
                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (winnerItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine($"Dragonwrath obtained!");
            }

            Dictionary<string, int> sortedLegendary = legendaryItems
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedLegendary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Dictionary<string, int> sortedJunk = junk
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
