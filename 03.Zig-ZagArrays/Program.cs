using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int num1 = input.Split().Select(int.Parse).ToArray()[0];
                int num2 = input.Split().Select(int.Parse).ToArray()[1];

                if (i % 2 == 0)
                {
                    array2[i] = num1;
                    array1[i] = num2;
                }
                else
                {
                    array1[i] = num1;
                    array2[i] = num2;
                }
            }

            foreach (int num in array2)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            foreach (int num in array1)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
