using System;
using System.Linq;
using System.Text;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            
            StringBuilder result=new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j <words[i].Length; j++)
                {
                    result.Append(words[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
