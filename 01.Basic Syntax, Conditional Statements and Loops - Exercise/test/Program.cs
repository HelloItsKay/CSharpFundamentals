using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age >=0 || age <=2  )
            {
                Console.WriteLine("Baby");
            }
        }
    }
}
