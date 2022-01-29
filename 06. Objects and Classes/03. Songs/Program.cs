using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp10
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string type, string n, string t)
        {
            TypeList = type;
            Name = n;
            Time = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine()
                    .Split('_');

                Song tempS = new Song(temp[0], temp[1], temp[2]);
                songs.Add(tempS);

            }
            string type = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                Song temp = songs[i];
                if (temp.TypeList == type)
                {
                    Console.WriteLine(temp.Name);
                }
                if (type == "all")
                {
                    Console.WriteLine(temp.Name);
                }
            }
        }
    }
}