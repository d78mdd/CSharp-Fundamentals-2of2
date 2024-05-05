using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetVowelsCount(input));
        }

        private static int GetVowelsCount(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
