using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(), reverse = "";
            int length = 0;
            length = username.Length - 1;
            int count = 0;
            while (length >= 0)
            {
                reverse = reverse + username[length];
                length--;
            }


            while (true)
            {

                string password = Console.ReadLine();
                if (password == reverse)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;

                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                count++;
                if (count >=3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
        }
    }
}
