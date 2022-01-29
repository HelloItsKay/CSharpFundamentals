using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(Grades(num));
        }

        static string Grades(double number)
        {
           

            if (number>=2.00 && number <= 2.99)
            {
                return  "Fail";
            }
            else if (number >= 3.00 && number <= 3.49)
            {
                return  "Poor";
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                return  "Good";
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                return  "Very good";
            }
            else if (number >= 5.50 && number <= 6.00)
            {
                return  "Excellent";
            }

            return String.Empty;
        }
    }
}
