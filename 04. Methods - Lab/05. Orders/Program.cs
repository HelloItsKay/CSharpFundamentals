using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine(Price(product,amount).ToString("0.00"));
        }

        static double Price(string product,int amount)
        {
           
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;

                case "water":
                    price = 1.00;
                    break;

                case "coke":
                    price = 1.40;
                    break;

                case "snack":
                    price = 2.00;
                    break;

                    default:
                        break;

                    
            }

            return price * amount;

        }
    }
}
