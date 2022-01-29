using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(Smallest(first,second,third));

        }

        static int Smallest(int a, int b, int c)
        {

            return Math.Min(a, Math.Min(b, c));
        }
    }
}
