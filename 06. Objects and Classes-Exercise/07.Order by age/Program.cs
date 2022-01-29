using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Order_by_age
{
    class Data
    {

        public Data(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> data = new List<Data>();

            string[] input = Console.ReadLine().Split();
            while (true)
            {
                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                int id = int.Parse(input[1]);
                int age = int.Parse(input[2]);
                Data newData = new Data(name, id, age);
                data.Add(newData);

                input = Console.ReadLine().Split();

            }

            foreach (var item in data.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
