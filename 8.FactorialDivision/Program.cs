using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double result = (double) GetFactorial(n1) / GetFactorial(n2);

            Console.WriteLine($"{result:F2}");
        }

        static int GetFactorial(int n)
        {
            int result = 1;

            if (n == 0)
            {
                result = 0;
            }

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
