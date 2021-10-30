using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Orders
{
    class Product
    {
        private string name;
        private double price;
        private int quanity;

        public Product()
        {

        }

        public Product(string name , double price , int quanity)
        {
            this.name = name;
            this.price = price;
            this.quanity = quanity;
        }

        public string Name
        {
            get => this.name;
            set => name = value;
        }

        public double Price
        {
            get => this.price;
            set => price = value;
        }

        public int Quanity
        {
            get => this.quanity;
            set => quanity = value;
        }
    }
}
