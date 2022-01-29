using System;
using System.ComponentModel.Design;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)

        {
            string weekDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (0<=age && age<=18  )
            {

                if (weekDay == "Weekday")
                {
                   price = 12; 
                }
                
                if (weekDay=="Weekend")
                {
                    price = 15;
                }

                if (weekDay=="Holiday")
                {
                    price = 5;
                }
            }



            if(18< age && age<=64 )
            {
               
                if (weekDay == "Weekday")
                {
                     price = 18;
                }

                if (weekDay == "Weekend")
                {
                    price = 20;
                }

                if (weekDay == "Holiday")
                {
                    price = 12;
                }
            }



            if (64< age && age <=122)
            {
                
                if (weekDay == "Weekday")
                {
                    price = 12;
                }
                if (weekDay == "Weekend")
                {
                    price = 15;
                }

                if (weekDay == "Holiday")
                {
                    price = 10;
                }
            }

            if (age>122 || age<0)
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"{price}$");
        }
    }
}
