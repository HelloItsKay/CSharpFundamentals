using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int sum = 0;
            int j = 1;



            for (int i = 1; i <= numb; i++)
            {

                Console.WriteLine(j);
                sum += j;
                j += 2;

            }

            Console.WriteLine($"Sum: {sum} ");
        }
    }
}
