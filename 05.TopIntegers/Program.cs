using System;
using System.Linq;

namespace _05.TopIntegers
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

                bool isGreat = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentNum <= array[j])
                    {
                        isGreat = false;
                        break;
                    }
                }
                if (isGreat)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}
