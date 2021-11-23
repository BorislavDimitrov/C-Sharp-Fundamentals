using System;
using System.Collections.Generic;
using System.Text;

namespace _06.PlantDiscovery
{
    class Plant
    {
        private string name;
        private double rarity;
        private double averageRating;

        public Plant()
        {

        }
        public Plant(string name)
        {
            this.name = name;
        }

        public Plant(string name, double rarity , double averageRating)
        {
            this.name = name;
            this.rarity = rarity;
            this.averageRating = averageRating;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Rarity
        {
            get => rarity;
            set => rarity = value;
        }

        public double AverageRating
        {
            get => averageRating;
            set => averageRating = value;
        }
    }
}
