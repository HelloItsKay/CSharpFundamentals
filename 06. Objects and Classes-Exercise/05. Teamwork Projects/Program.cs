using System;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTheTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTheTeams; i++)
            {
                string[] teams = Console.ReadLine().Split("-");

                string teamName = teams[0];
                string user = teams[1];

                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }
        }
    }
}
