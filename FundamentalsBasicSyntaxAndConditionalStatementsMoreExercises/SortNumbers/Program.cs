using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int biggest = 0;
            int middle = 0;
            int last = 0;
            
            if ( num1 >= num2 && num1 >= num3)
            {
                biggest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                biggest = num2;
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                biggest = num3;
            }

            if ((num1 >= num2 && num1 <= num3) || (num1 <= num2 && num1 >= num3))
            {
                middle = num1;
            }
            else if ((num2 >= num1 && num2 <= num3) || (num2 <= num1 && num2 >= num3))
            {
                middle = num2;
            }
            else if ((num3 >= num2 && num3 <= num1) || (num3 <= num2 && num3 >= num1))
            {
                middle = num3;
            }

            if (num1 <= num2 && num1 <= num3)
            {
                last = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                last = num2;
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                last = num3;
            }

            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(last);
        }
    }
}
