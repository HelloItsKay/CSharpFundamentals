using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{


    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }



    class Program
    {



        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split("/");

                if (command == "end")
                {
                    break;
                }

                if (parts[0] == "Car")
                {
                    string brand = parts[1];
                    string model = (parts[2]);
                    int horsePower = int.Parse(parts[3]);

                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    cars.Add(car);
                }
                else if (parts[0] == "Truck")
                {
                    string brand = parts[1];
                    string model = parts[2];
                    int weight = int.Parse(parts[3]);

                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    trucks.Add(truck);
                }

                // command = Console.ReadLine();

            }

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in trucks.OrderBy(y => y.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}







