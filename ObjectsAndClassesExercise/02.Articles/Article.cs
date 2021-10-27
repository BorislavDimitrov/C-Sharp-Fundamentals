using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title , string content , string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void EditContent (string content)
        {
            Content = content;
        }

        public void ChangeAuthor (string author)
        {
            Author = author;
        }

        public void ChangeTitle (string title)
        {
            Title = title;
        }

        public static void PrintArticle (Article article)
        {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
