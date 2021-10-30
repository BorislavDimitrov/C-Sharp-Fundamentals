using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DragonArmy
{
    class Dragon
    {
        private string type;
        private string name;
        private double damage;
        private double health;
        private double armor;

        public Dragon()
        {

        }

        public Dragon(string type , string name , double damage , double health , double armor)
        {
            this.type = type;
            this.name = name;
            this.damage = damage;
            this.health = health;
            this.armor = armor;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Damage
        {
            get => damage;
            set => damage = value;
        }

        public double Health
        {
            get => health;
            set => health = value;
        }

        public double Armor
        {
            get => armor;
            set => armor = value;
        }
    }
}
