using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Snowwhite
{
    class Dwarf
    {
        private string name;
        private string color;
        private int physic;
        private int countOfColorGroup;

        public Dwarf()
        {

        }

        public Dwarf(string name, string color, int physic)
        {
            this.name = name;
            this.color = color;
            this.physic = physic;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public int Physic
        {
            get => physic;
            set => physic = value;
        }

        public int CountOfColorGroup
        {
            get => countOfColorGroup;
            set => countOfColorGroup = value;
        }
    }
}
