using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 5]
            {
                {0,6,4,3,5},
                {25,23,1,5,0},
            };
           


            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        if (a[i, j] > a[i, j - 1])
                        {
                            int temp = a[i, j];
                            a[i, j] = a[i, j - 1];
                            a[i, j - 1] = temp;
                        }
                    }

                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{a[i, j]}");
                }

                Console.WriteLine();
            }

        }
    }
}
