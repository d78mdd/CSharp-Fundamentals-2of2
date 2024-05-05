using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            PrintString(s, n);
        }

        static void PrintString(string s, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(s);
            }
        }

    }
}
