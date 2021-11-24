using System;
using System.Text.RegularExpressions;

namespace _11.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex  pattern = new Regex(@"@#+(?<code>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string group = string.Empty;
                bool isNumber = false;

                if (pattern.IsMatch(input))
                {
                    Match validBarcode = pattern.Match(input);

                    for (int j = 0; j < validBarcode.Groups["code"].Value.Length; j++)
                    {
                        if ((int)validBarcode.Groups["code"].Value[j] >= 48 && (int)validBarcode.Groups["code"].Value[j] <= 57)
                        {
                            group += (char)validBarcode.Groups["code"].Value[j];
                            isNumber = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                if (isNumber)
                {
                    Console.WriteLine($"Product group: {group}");

                }
                else
                {
                    Console.WriteLine($"Product group: 00");
                }
            }
        }
    }
}
