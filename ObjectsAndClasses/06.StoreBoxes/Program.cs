using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> data = input.Split().ToList();
                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuanity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Item item = new Item();
                Box box = new Box();

                item.Name = itemName;
                item.Price = itemPrice;

                box.SerialNumber = serialNumber;
                box.Item = item;
                box.PriceForBox = itemPrice * itemQuanity;
                box.ItemQuanity = itemQuanity;
                boxes.Add(box);
            }

            for (int i = 0; i < boxes.Count; i++)
            {
                for (int j = 0; j < boxes.Count - 1; j++)
                {
                    if (boxes[j].PriceForBox < boxes[j + 1].PriceForBox)
                    {
                        Box temp = boxes[j];
                        boxes[j] = boxes[j + 1];
                        boxes[j + 1] = temp;

                    }
                }
            }

            for (int i = 0; i < boxes.Count; i++)
            {
                Console.WriteLine(boxes[i].SerialNumber);
                Console.WriteLine($"-- {boxes[i].Item.Name} - ${boxes[i].Item.Price:F2}: {boxes[i].ItemQuanity}");
                Console.WriteLine($"-- ${boxes[i].PriceForBox:F2}");
            }
        }
    }
}
