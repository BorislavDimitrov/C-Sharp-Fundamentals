using System;

namespace _PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (CheckPasswordLenght(password) == true && CheckIfCharsAreValid(password) == true && CheckIfContains2Digits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }

            if (CheckPasswordLenght(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (CheckIfCharsAreValid(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (CheckIfContains2Digits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool CheckPasswordLenght (string password)
        {
            bool isInLenght;
            if (password.Length >= 6 && password.Length <= 10 )
            {
                isInLenght = true;
            }
            else
            {
                isInLenght = false;
            }
            return isInLenght;
        }

        static bool CheckIfCharsAreValid (string password)
        {
            bool isCharsValid = true;

            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122) || (password[i] >= 48 && password[i] <= 57))
                {
                    isCharsValid = true;
                }
                else
                {
                    isCharsValid = false;
                    break;
                }
            }
            return isCharsValid;
        }

        static bool CheckIfContains2Digits (string password)
        {
            bool isDigitsTwo = false;
            int digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            { 
                    bool isNum = int.TryParse(password[i].ToString() , out _);

                    if (isNum)
                    {
                        digitsCounter++;
                        if (digitsCounter == 2)
                        {
                            isDigitsTwo = true;
                            break;
                        }
                    }
            }
            return isDigitsTwo;
        }
    }
}
