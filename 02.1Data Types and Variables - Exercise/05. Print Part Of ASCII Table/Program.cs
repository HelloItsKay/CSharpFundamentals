using System;
using System.Threading;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());


            while (endNumber >=startNumber)
            {

                //Console.Write(startNumber);

                Console.Write($"{(char)startNumber} ");
                
                startNumber++;
            }
        }
    }
}
