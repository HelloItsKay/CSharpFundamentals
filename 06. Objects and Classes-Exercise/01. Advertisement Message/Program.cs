using System;

namespace _01._Advertisement_Message
{

    class AdvMessage
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] author =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"

            };

            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"

            };


            Random random=new Random();

            for (int i = 0; i < n; i++)
            {
                int phraseIndex = random.Next(0,phrases.Length);
                int eventIndex = random.Next(0, events.Length);
                int authorIndex = random.Next(0, author.Length);
                int citiesIndex = random.Next(0, cities.Length);
               
                string mesage = $"{phrases[phraseIndex]} {events[eventIndex]} {author[authorIndex]} – {cities[citiesIndex]}";

                Console.WriteLine($"{mesage}");
            }

            
        }

    }
}
