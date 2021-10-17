using System;

namespace _DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            if (inputType == "int")
            {
                string intNum = Console.ReadLine();
                ReturnByDataType(inputType , intNum);
            }
            else if (inputType == "real")
            {
                string doubleNum = Console.ReadLine();
                ReturnByDataType(inputType , doubleNum);
            }
            else if (inputType == "string")
            {
                string input = Console.ReadLine();
                ReturnByDataType(inputType , input);
            }
        }

        static void ReturnByDataType (string inputType ,string value)
        {
            if (inputType == "int")
            {
                int num = int.Parse(value);
                int sum = num * 2;
                Console.WriteLine(sum);
            }
            else if (inputType == "real")
            {
                double num = double.Parse(value);
                double sum = num * 1.5;
                Console.WriteLine($"{sum:F2}");
            }
            else if (inputType == "string")
            {
                string result = "$" + $"{value}" + "$";
                Console.WriteLine(result);
            }
        }
    }
}
