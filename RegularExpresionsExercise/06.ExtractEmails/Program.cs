using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(?<=\s)(?<user>[a-zA-Z0-9]+[\.|\-|_]?[a-zA-Z0-9]*)@(?<host>[a-zA-z]+[\-]?[a-zA-z]+(\.[a-z]{2,100})+)");
            List<string> emails = pattern.Matches(input)
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join("\n" , emails));
        }
    }
}
