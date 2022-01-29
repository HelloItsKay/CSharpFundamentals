﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Articles
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ");

                Article article = new Article()
                {
                    Title = articleData[0],
                    Content = articleData[1],
                    Author = articleData[2],
                };
                articles.Add(article);
            }




            string soortingCriteria = Console.ReadLine();

            List<Article> sort = new List<Article>();
            if (soortingCriteria == "title")
            {
                sort = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }

            else if (soortingCriteria == "content")
            {
                sort = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }

            else
            {
                sort = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }

            foreach (var article in sort)
            {
                Console.WriteLine(article);
            }


        }
    }
}