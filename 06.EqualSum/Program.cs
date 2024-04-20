using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];

                int leftSum = 0;
                int rightSum = 0;

                // get left sum
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                // get right sum
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    Console.Write(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
