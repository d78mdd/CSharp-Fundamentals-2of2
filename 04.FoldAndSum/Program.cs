using System;
using System.Linq;

namespace _04.FoldAndSum
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

            int k = allNumbers.Length / 4;

            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];

            int[] sums = new int[k * 2];


            {
                //first row first k numbers
                int r = 0;
                for (int i = k - 1; i >= 0; i--)
                {
                    firstRow[r] = allNumbers[i];
                    r++;
                }
                //first row last k numbers
                for (int i = allNumbers.Length - 1; i > k * 3 - 1; i--)
                {
                    firstRow[r] = allNumbers[i];
                    r++;
                }
            }


            //2nd row
            {
                int r = 0;
                for (int i = k; i <= k * 3 - 1; i++)
                {
                    secondRow[r] = allNumbers[i];
                    r++;
                }
            }


            //sum and print
            for (int i = 0; i < k * 2; i++)
            {
                sums[i] = firstRow[i] + secondRow[i];

                Console.Write($"{sums[i]} ");
            }

        }
    }
}
