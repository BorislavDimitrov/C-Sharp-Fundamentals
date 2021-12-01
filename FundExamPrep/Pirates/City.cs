using System;
using System.Collections.Generic;
using System.Text;

namespace _15.Pirates
{
    class City
    {
        private string name;
        private double population;
        private double gold;

        public City()
        {

        }

        public City(string name, double population , double gold)
        {
            this.name = name;
            this.population = population;
            this.gold = gold;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Population
        {
            get => population;
            set => population = value;
        }

        public double Gold
        {
            get => gold;
            set => gold = value;
        }
    }
}
