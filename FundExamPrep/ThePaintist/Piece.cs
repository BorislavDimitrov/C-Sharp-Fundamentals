using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ThePaintist
{
    class Piece
    {
        private string name;
        private string composer;
        private string key;

        public Piece()
        {

        }

        public Piece(string name , string composer , string key)
        {
            this.name = name;
            this.composer = composer;
            this.key = key;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Composer
        {
            get => composer;
            set => composer = value;
        }

        public string Key
        {
            get => key;
            set => key = value;
        }
    }
}
