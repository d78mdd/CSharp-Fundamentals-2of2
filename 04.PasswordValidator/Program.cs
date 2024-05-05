using System;
using System.Linq;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            ValidatePassword(password);
        }

        private static void ValidatePassword(string password)
        {
            bool valid = true;

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid = false;
            }

            bool hasSpecialSymbols = false;
            foreach (char c in password)
            {
                if (!"1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".Contains(c))
                {
                    hasSpecialSymbols = true;
                    break;
                }
            }
            if (hasSpecialSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valid = false;
            }

            int digits = 0;
            foreach (char c in password)
            {
                if ("1234567890".Contains(c))
                {
                    digits++;
                }
            }
            if (digits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid = false;
            }

            if (valid)
            {
                Console.WriteLine("Password is valid");
            }
            
        }

    }
}
