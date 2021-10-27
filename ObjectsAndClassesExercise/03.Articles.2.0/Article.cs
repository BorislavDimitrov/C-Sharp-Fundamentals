namespace _03.Articles._2._0
{
    internal class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title , string content , string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }


    }
}