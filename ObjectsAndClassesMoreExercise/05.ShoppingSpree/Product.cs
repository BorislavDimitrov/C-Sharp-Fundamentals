using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ShoppingSpree
{
    class Product
    {
        private string name;
        private double cost;

        public Product()
        {

        }

        public Product(string name , double cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Cost
        {
            get => cost;
            set => cost = value;
        }
    }
}
