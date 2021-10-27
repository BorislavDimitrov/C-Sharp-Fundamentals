using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string input = Console.ReadLine();
                List<string> infos = input.Split(", ").ToList();

                string title = infos[0];
                string content = infos[1];
                string author = infos[2];

                Article article = new Article(title , content , author);

                articles.Add(article);
            }

            string sortBy = Console.ReadLine();

            Sort(sortBy , ref articles);

            PrintArticles(articles);
        }

        static void Sort (string sortBy ,ref  List<Article>  articles)
        {
            if (sortBy == "title")
            {
                articles = articles.OrderBy(article => article.Title).ToList();
            }
            else if (sortBy == "content")
            {
               articles = articles.OrderBy(article => article.Content).ToList();
            }
            else if (sortBy == "author")
            {
               articles = articles.OrderBy(article => article.Author).ToList();
            }
        }

        static void PrintArticles(List<Article> articles)
        {
            for (int i = 0; i < articles.Count; i++)
            {
                Console.WriteLine($"{articles[i].Title} - {articles[i].Content}: {articles[i].Author}");
            }
        }
    }
}
