using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleInfo = Console.ReadLine().Split(';').ToList();
            List<string> productsInfo = Console.ReadLine().Split(';' , StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < peopleInfo.Count; i++)
            {
                string personAndMoneyInfo = peopleInfo[i];
                List<string> personInfo = personAndMoneyInfo.Split('=').ToList();
                string personName = personInfo[0];
                double personMoney = double.Parse(personInfo[1]);

                Person currentPerson = new Person(personName , personMoney);
                people.Add(currentPerson);
            }

            for (int i = 0; i < productsInfo.Count; i++)
            {
                string productInfo = productsInfo[i];
                List<string> productInfos = productInfo.Split('=').ToList();
                string currentProductName = productInfos[0];
                double currentProductCost = double.Parse(productInfos[1]);

                Product currentProduct = new Product(currentProductName , currentProductCost);
                products.Add(currentProduct);
            }

            string input = string.Empty;

            while ((input= Console.ReadLine()) != "END")
            {
                List<string> personAndProductToBuy = input.Split().ToList();
                string personName = personAndProductToBuy[0];
                string productName = personAndProductToBuy[1];

                Person currentPerson = TakePersonByName(people , personName);
                Product currentProduct = TakeProductByName(products , productName);

                if (currentPerson.CheckIfPersonCanAffordProduct(currentProduct))
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i].Name == currentPerson.Name)
                        {
                            people[i].PersonBuysAProduct(currentProduct);
                            Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }

            }
            Person.PrintListOfPeople(people);
        }

        static Person TakePersonByName (List<Person> people , string personName)
        {
            Person searchedPerson = new Person();

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Name == personName)
                {
                    searchedPerson = people[i];
                }
            }

            return searchedPerson;
        }

        static Product TakeProductByName (List<Product> products , string productName)
        {
            Product searchedProduct = new Product();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == productName)
                {
                    searchedProduct = products[i];
                    break;
                }
            }

            return searchedProduct;
        }
    }
}
