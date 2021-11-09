using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            Regex patern = new Regex(@"\++359(-| )2\1\d{3}\1\d{4}\b");

            var phoneNums = patern.Matches(phoneNumbers)
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", " , phoneNums));
        }
    }
}
