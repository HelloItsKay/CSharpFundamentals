using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string bestKegModel=String.Empty;
            double bestVolume = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                
                double volume= Math.PI*Math.Pow(radius,2)*height;

                if (volume>bestVolume)
                {
                    bestVolume = volume;
                    bestKegModel = model;
                }
            }

            Console.WriteLine(bestKegModel);
        }
    }
}
