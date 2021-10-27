using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AdveristimateMassege
{
    class FakeMessage
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }

        public FakeMessage(string phrase , string eventt , string author , string city)
        {
            this.Phrase = phrase;
            this.Event = eventt;
            this.Author = author;
            this.City = city;
        }
    }
}
