using System;
using System.Threading;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double sabres = Math.Ceiling(countOfStudents * 1.1);
            
            double beltDiscounted = countOfStudents-Math.Floor((countOfStudents/6));
          




            double totalPrice =sabres*priceOfLightSabers+beltDiscounted*priceOfBelts+priceOfRobes*countOfStudents;
            double moneyNeeded = Math.Abs(totalPrice - amountOfMoney);
            if (amountOfMoney>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:F2}lv more.");}
            }
        }
    }

