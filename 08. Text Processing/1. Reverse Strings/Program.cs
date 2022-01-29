using System;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                
                 var reverse = input.ToArray().Reverse();

                Console.WriteLine($"{input} = {string.Join("", reverse)}");
            }
            
            
        }
    }
}
