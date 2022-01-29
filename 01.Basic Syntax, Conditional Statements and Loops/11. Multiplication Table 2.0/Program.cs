using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplexer = int.Parse(Console.ReadLine());
            int sum2 = 0;

            if (multiplexer > 10)
            {
                sum2 = num * multiplexer;
                Console.WriteLine($"{num} X {multiplexer} = {sum2}");

            }
            for (int i = multiplexer; i <= 10; i++)
            {
                int sum = num * i;
                Console.WriteLine($"{num} X {i} = {sum}");

            }





        }
    }
}
