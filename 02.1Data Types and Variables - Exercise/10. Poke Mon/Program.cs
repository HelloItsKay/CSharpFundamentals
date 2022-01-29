using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int originN = pokePower;
            int targets = 0;


            while (pokePower>=distance)
            {
                pokePower -= distance;
                targets += 1;

                if (pokePower== originN / 2 && exhaustion>0)
                {
                    pokePower /= exhaustion;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targets);
        }
    }
}
