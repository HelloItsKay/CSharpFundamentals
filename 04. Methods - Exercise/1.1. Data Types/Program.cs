using System;

namespace _1._1._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input=="int")
            {
                int  intager = int.Parse(Console.ReadLine());
                MultiplyBy2ForIntagers(intager);
            }
            else if (input=="real")
            {
                double real = double.Parse(Console.ReadLine());
                MultiplyByHalfForDouble(real);
                
            }
            else if (input=="string")
            {
                string str = Console.ReadLine();
                SurroundByDolarsForString(str);
            }

        }

        static void MultiplyBy2ForIntagers(int num)
        {
            Console.WriteLine(num*2);
        }

        static void MultiplyByHalfForDouble(double num)
        {
            Console.WriteLine($"{(num*1.5):f2}");
        }

        static void SurroundByDolarsForString(string str)
        {
            Console.WriteLine($"${str}$");
        }
}
}
