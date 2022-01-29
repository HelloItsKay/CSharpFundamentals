    using System;
    using System.Collections.Generic;

    namespace _5._SoftUni_Parking
    {
        class Program
        {
            static void Main(string[] args)
            {
                Dictionary<string, string> licenseByName = new Dictionary<string, string>();

                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    string[] input = Console.ReadLine().Split();
                   
                     string command = input[0];
                    if (command== "register")
                    {
                       
                        string username = input[1];
                        string licensePlateNumber = input[2];

                        if (licenseByName.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        else
                        {
                            licenseByName.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                    }
                    else
                    {
                        string username = input[1];
                        bool removed = licenseByName.Remove(username);

                        if (removed)
                        {
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }

                    }
                }

                foreach (var item in licenseByName)
                {
                    Console.WriteLine($"{item.Key} => {item.Value}");
                }
            }
        }
    }
