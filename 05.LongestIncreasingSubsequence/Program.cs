using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] allNumbers = input
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

        }
    }
}
