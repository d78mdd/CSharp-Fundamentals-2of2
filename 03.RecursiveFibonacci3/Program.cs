using System;

namespace _03.RecursiveFibonacci3
{
    class Program
    {
        static int[] memoizated;
        static int i = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            memoizated = new int[n];
            if (n > 0)
            {
                memoizated[0] = 1;
                i++;
            }
            if (n > 1)
            {
                memoizated[1] = 1;
                i++;
            }

            Console.WriteLine(GetFibonacci(n));
        }

        static int GetFibonacci(int n)
        {
            if (memoizated[n - 1] != 0)
            {
                return memoizated[n - 1];
            }

            int result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            memoizated[i] = result;
            i++;
            return result;
        }
    }
}
