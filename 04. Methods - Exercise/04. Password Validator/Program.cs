using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.CompilerServices;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = true;

            if (!ValidLenght(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                isValid = false;
            }

            if (ValidCharacter(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ContainsDigits(input, 2))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isValid = false;
            }

            if (isValid==true)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        private static bool ValidLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool ValidCharacter(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }

            }

            return false;
        }

        static bool ContainsDigits(string password, int count)
        {
            var foundDigitsCount = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    foundDigitsCount += 1;
                }

                if (foundDigitsCount == count)
                {
                    return true;
                }


            }
            return false;
        }
    }
}
