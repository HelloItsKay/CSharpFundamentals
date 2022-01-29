using System;
using System.Text;

namespace _7._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result=new StringBuilder();
            int bomb = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol=='>')
                {
                    bomb += input[i + 1] - '0';
                    result.Append(symbol);
                }
                else if (bomb>0)
                {
                    bomb -= 1;
                }
                else
                {
                    result.Append(symbol);
                }
            }

            Console.WriteLine(result);
        }
    }
}
