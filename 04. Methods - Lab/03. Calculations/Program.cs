using System;
using System.Reflection.Metadata.Ecma335;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculations(comand,firstNumber,secondNumber));
        }

        static string Calculations(string operation, int a, int b)
        {
            int result = 0;
            if (operation=="add")
            {
                result = a + b;

            }

            if (operation=="multiply")
            {
                result = a * b;
            }

            if (operation== "subtract")
            {
                result= a - b;
            }

            if (operation=="divide")
            {
                result= a / b;
            }

            return $"{result}";

        }
        
    }
}
