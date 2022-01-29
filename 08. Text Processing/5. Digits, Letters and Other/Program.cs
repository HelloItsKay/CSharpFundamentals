using System;
using System.Text;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();




            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {

                var text = line[i];

                if (char.IsDigit(text))
                {
                    numbers.Append(text);
                }
                else if (char.IsLetter(text))
                {
                    letters.Append(text);
                }
                else
                {
                    other.Append(text);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
