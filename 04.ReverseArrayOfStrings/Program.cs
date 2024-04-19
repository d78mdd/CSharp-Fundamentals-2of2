using System;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] strings = input.Split(' ');

            for (int i = strings.Length - 1; i >=0 ; i--)
            {
                Console.Write(strings[i]);
                Console.Write(" ");
            }
        }
    }
}
