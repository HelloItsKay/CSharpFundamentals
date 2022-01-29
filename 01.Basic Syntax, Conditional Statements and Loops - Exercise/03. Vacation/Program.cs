using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            string day = Console.ReadLine();



            double total;
            if (people == "Students")
            {
                if (day == "Friday")
                {
                    total = count * 8.45;
                }
                else if (day == "Saturday")
                {
                    total = count * 9.8;
                }
                else
                {
                    total = count * 10.46;
                }

                if (count >= 30)
                {
                    total = total - (total * 15 / 100);
                }
            }

            else if (people == "Business")
            {
                if (count >= 100)
                {
                    count -= 10;
                }

                if (day == "Friday")
                {
                    total = count * 10.9;
                }
                else if (day == "Saturday")
                {
                    total = count * 15.6;
                }
                else
                {
                    total = count * 16;
                }
            }

            else
            {
                if (day == "Friday")
                {
                    total = count * 15;
                }
                else if (day == "Saturday")
                {
                    total = count * 20;
                }
                else
                {
                    total = count * 22.5;
                }

                if (count >= 10 && count <= 20)
                {
                    total = total - (total * 5 / 100);
                }
            }

            Console.WriteLine($"Total price: {total.ToString("0.00")}");
        }
    }
}

