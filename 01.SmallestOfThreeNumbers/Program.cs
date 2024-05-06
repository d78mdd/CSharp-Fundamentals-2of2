using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(num1, num2, num3));
        }

        private static int GetMin(int num1, int num2, int num3)
        {
            return Math.Min(Math.Min(num1, num2), num3);
        }
    }
}
