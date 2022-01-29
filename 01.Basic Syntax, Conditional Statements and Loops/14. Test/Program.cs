using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            


            if (times > 10)
            {
                Console.WriteLine($"{numb} X {times} = {numb * times}");
            }

            else if (times <= 10)
            {
                Console.WriteLine($"{numb} X {times} = {numb * times}");
                times++;

            }


        }
    }
}