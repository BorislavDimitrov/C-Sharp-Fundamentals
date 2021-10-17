using System;

namespace _TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (CheckIfDividibleBy8(i) == true && CheckOddDigit(i) == true)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool CheckIfDividibleBy8(int n)
        {
            bool isDividible = false;
            string number = $"{n}";
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            if (sum % 8 == 0)
            {
                isDividible = true;
            }

            return isDividible;
        }

        static bool CheckOddDigit (int n)
        {
            bool isOdd = false;
            string number = $"{n}";

            for (int i = 0; i < number.Length; i++)
            {
                if (int.Parse(number[i].ToString()) % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
            }

            return isOdd;
        }
    }
}
