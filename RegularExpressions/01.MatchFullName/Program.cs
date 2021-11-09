using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex patern = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");
            var names = patern.Matches(text);

            foreach (Match match in names)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
