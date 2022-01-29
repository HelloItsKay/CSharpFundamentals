using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06._Vehicle_Catalogue
{
    class Car
    {

        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }

    class Truck
    {

        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            double carHP = 0;
            double truckHP = 0;

            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {

                string type = input[0];
                string model = input[1];
                string color = input[2];
                int power = int.Parse(input[3]);

                if (input[0] == "car")
                {
                    Car newCar = new Car(model, color, power);
                    cars.Add(newCar);
                    carHP += newCar.HorsePower;
                }
                else
                {
                    Truck newTruck = new Truck(model, color, power);
                    trucks.Add(newTruck);
                    truckHP += newTruck.HorsePower;
                }

                input = Console.ReadLine().Split();
            }

            string[] input2 = Console.ReadLine().Split();
            string chek = string.Join(" ", input2);

            while (true)
            {
                if (chek == "Close the Catalogue")
                {
                    break;
                }

                if (cars.Any(x => x.Model == input2[0]))
                {
                    foreach (var item in cars.Where(x => x.Model == input2[0]))
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
                else if (trucks.Any(x => x.Model == input2[0]))
                {
                    foreach (var item in trucks.Where(x => x.Model == input2[0]))
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");

                    }
                }


                input2 = Console.ReadLine().Split();
                chek = string.Join(" ", input2);



            }
            double averageCarsHorsepower = carHP / cars.Count;
            double averageTrucksHorsepower = truckHP / trucks.Count;
            if (cars.Count>0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carHP / cars.Count:F2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckHP / trucks.Count:F2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
