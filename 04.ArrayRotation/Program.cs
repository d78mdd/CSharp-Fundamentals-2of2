using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] rotated = new int[array.Length]; ;

            int lastIndex = array.Length - 1;
            int nextToLastIndex = lastIndex - 1;

            // 1 iteration = "rotation"
            for (int i = 0; i < rotations; i++)
            {
                rotated = new int[array.Length];

                // assign last number of the "rotated" array
                rotated[lastIndex] = array[0];

                // assign the remaining numbers of the "rotated" array
                for (int j = 0; j <= nextToLastIndex; j++)
                {
                    rotated[j] = array[j + 1];
                }

                array = rotated;
            }

            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
