using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax());

        }

        static string GetMax()
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (type == "int")
            {
                return (Math.Max(double.Parse(first), double.Parse(second))).ToString();
            }

            char[] a = first
                .ToCharArray();

            char[] b = second
                .ToCharArray();

            if ((int)a[0] > (int)b[0])
            {
                return first;
            }
            else
            {
                return second;
            }
        }

    }
}
