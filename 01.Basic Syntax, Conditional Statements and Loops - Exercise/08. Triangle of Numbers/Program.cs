﻿using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    
                        Console.Write($"{i} ");
                   




                }
            }
        }
    }

}
