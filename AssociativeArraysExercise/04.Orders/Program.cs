using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();
            List<Product> productsList = new List<Product>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                List<string> productInfo = input.Split().ToList();
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                int productQuanity = int.Parse(productInfo[2]);
                Product newProduct = new Product(productName , productPrice , productQuanity);
                bool productExist = false;

                for (int i = 0; i < productsList.Count; i++)
                {
                    if (productsList[i].Name == productName)
                    {
                        productExist = true;
                        productsList[i].Price = productPrice;
                        productsList[i].Quanity += productQuanity;
                    }
                }

                if (!productExist)
                {
                    productsList.Add(newProduct);
                }
            }

            for (int i = 0; i < productsList.Count; i++)
            {
                double currentProductTotalPrice = productsList[i].Price * productsList[i].Quanity;
                products.Add(productsList[i].Name , currentProductTotalPrice);
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:F2}");
            }
        }
    }
}
