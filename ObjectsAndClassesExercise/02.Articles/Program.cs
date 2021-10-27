using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> articleInfos = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string title = articleInfos[0];
            string content = articleInfos[1];
            string author = articleInfos[2];

            Article article = new Article(title , content , author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();
                string action = command[0];
                string newInfo = command[1];

                if (action == "Edit")
                {
                    article.EditContent(newInfo);
                }
                else if (action == "ChangeAuthor")
                {
                    article.ChangeAuthor(newInfo);
                }
                else if (action == "Rename")
                {
                    article.ChangeTitle(newInfo);
                }
            }

            Article.PrintArticle(article);
        }
    }
}
