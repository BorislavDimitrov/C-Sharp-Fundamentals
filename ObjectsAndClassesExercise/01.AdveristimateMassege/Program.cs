using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AdveristimateMassege
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product."
                , "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome."
                    , "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessages = int.Parse(Console.ReadLine());
            
            Random rand = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                 int randomPhraseIndex = rand.Next(0 , phrases.Count);
                int randomEventIndex = rand.Next(0 , events.Count);
                int randomAuthorIndex = rand.Next(0 , authors.Count);
                int randomCityIndex = rand.Next(0 , cities.Count);

                FakeMessage fakeMessage = new FakeMessage(phrases[randomPhraseIndex] , events[randomEventIndex] , authors[randomAuthorIndex] , cities[randomCityIndex] );

                Console.WriteLine($"{fakeMessage.Phrase} {fakeMessage.Event} {fakeMessage.Author} - {fakeMessage.City}.");
            }
        }
    }


}
