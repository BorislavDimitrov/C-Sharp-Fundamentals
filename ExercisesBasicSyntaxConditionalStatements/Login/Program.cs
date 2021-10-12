using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char index = username[i];
                password += index;
            }

            for (int i = 1; i <= 4; i++)
            {
                string guessPassword = Console.ReadLine();

                if (guessPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if (i == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }
    }
}
