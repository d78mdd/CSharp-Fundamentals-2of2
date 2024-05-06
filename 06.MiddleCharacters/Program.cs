using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            GetMiddleCharacters(str);
        }

        static void GetMiddleCharacters(string str)
        {
            if (str.Length % 2 == 0)
            {
                Console.Write(str[str.Length / 2 - 1]);
                Console.WriteLine(str[str.Length / 2]);
            }
            else
            {
                Console.WriteLine(str[str.Length / 2]);
            }
            
        }
    }
}
