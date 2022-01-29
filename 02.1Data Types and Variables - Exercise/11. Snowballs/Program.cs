using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());


            BigInteger bestValue = 0;
            int bestSnow = 0;
            int bestQuality = 0;
            int bestTime = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                 int snowballTime = int.Parse(Console.ReadLine());
                 int snowballQuality = int.Parse(Console.ReadLine());

                int sDivider = snowballSnow / snowballTime;
                 BigInteger snowballValue =BigInteger.Pow(sDivider, snowballQuality);

                if (snowballValue>bestValue)
                {
                    bestValue=snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
