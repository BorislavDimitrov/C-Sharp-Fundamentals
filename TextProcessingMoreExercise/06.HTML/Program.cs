using System;
using System.Collections.Generic;

namespace _06.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            string input = string.Empty;
            List<string> comments = new List<string>();

            while ((input = Console.ReadLine()) != "end of comments")
            {
                comments.Add(input);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"\t{articleTitle}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"\t{articleContent}");
            Console.WriteLine("</article>");

            for (int i = 0; i < comments.Count; i++)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"\t{comments[i]}");
                Console.WriteLine("</div>");
            }
        }
    }
}
