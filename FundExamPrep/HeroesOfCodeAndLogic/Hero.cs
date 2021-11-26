using System;
using System.Collections.Generic;
using System.Text;

namespace _12.HeroesOfCodeAndLogic
{
    class Hero
    {
        private string name;
        private double healthPoints;
        private double manaPoints;


        public Hero()
        {

        }

        public Hero(string name , double healthPoints , double manaPoints)
        {
            this.name = name;
            this.healthPoints = healthPoints;
            this.manaPoints = manaPoints;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double HealthPoints
        {
            get => healthPoints;
            set => healthPoints = value;
        }

        public double ManaPoints
        {
            get => manaPoints;
            set => manaPoints = value;
        }
    }
}
