using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, heigth = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            heigth = (length * width * heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {heigth:f2}");

        }
    }
}
