using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int expectedSum = int.Parse(Console.ReadLine());

            if (array.Length < 2)
            {
                return;
            }

            bool[] usedNums = new bool[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (usedNums[i])
                {
                    continue;
                }

                int num1 = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (usedNums[j])
                    {
                        continue;
                    }

                    int num2 = array[j];

                    if (num1 + num2 == expectedSum)
                    {
                        Console.WriteLine($"{num1} {num2}");
                        usedNums[i] = true;
                        usedNums[j] = true;
                        break;
                    }
                }

            }

        }
    }
}
