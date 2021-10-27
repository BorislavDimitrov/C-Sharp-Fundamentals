using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ShoppingSpree
{
    class Person
    {
        private string name;
        private double money;
        private List<Product> products = new List<Product>();

        public Person(string name , double money)
        {
            this.name = name;
            this.money = money;
        }

        public Person(string name , double money , List<Product> products)
        {
            this.name = name;
            this.money = money;
            this.products = products;
        }
        public Person()
        {

        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Money
        {
            get => money;
            set => money = value;
        }

        public List<Product> Products
        {
            get => products;
            set => products = value;
        }

        public bool CheckIfPersonCanAffordProduct (Product product)
        {
            bool isMoneyEnough = false;

            if (money >= product.Cost)
            {
                isMoneyEnough = true;
            }
            return isMoneyEnough;
        }

        public void PersonBuysAProduct (Product product)
        {
            money -= product.Cost;
            products.Add(product);
        }

        public static void PrintListOfPeople (List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].products.Count == 0)
                {
                    Console.WriteLine($"{people[i].name} - Nothing bought");
                }
                else
                {
                    Console.Write($"{people[i].name} - ");

                    for (int j = 0; j < people[i].products.Count; j++)
                    {
                        if (j + 1 < people[i].products.Count)
                        {
                            Console.Write($"{people[i].Products[j].Name}, ");
                        }
                        else
                        {
                            Console.WriteLine($"{people[i].Products[j].Name}");
                        }
                    }
                }
            }
        }
    }
}
