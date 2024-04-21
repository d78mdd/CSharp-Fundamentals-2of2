using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                return;
            }
            else if (n == 1)
            {
                Console.WriteLine("1");
                return;
            }
            else if (n == 2)
            {
                Console.WriteLine("1");
                Console.WriteLine("1 1");
                return;
            }


            int[] prevArr = new int[2];
            prevArr[0] = 1;
            prevArr[1] = 1;

            Console.WriteLine(1);
            Console.WriteLine($"{prevArr[0]} {prevArr[1]}");


            for (int i = 1; i < n - 1; i++)
            {
                // construct the array
                int[] arr = new int[prevArr.Length + 1];
                arr[0] = 1;
                for (int j = 1; j < prevArr.Length; j++)
                {
                    arr[j] = prevArr[j - 1] + prevArr[j];
                }
                arr[prevArr.Length] = 1;
                prevArr = arr;

                // print the array
                foreach (int num in arr)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }

        }
    }
}
