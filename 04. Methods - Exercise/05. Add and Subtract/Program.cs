using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(first,second,third));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b, int c)
        {
            return Sum(a, b) - c;
        }
    }
}
