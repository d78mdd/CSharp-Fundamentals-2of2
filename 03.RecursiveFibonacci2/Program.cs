using System;

namespace _03.RecursiveFibonacci2
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
            int memoizatedElem = GetMemoizated(n);

            if (memoizatedElem != -1)
            {
                return memoizatedElem;
            }

            int result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            memoizated[i] = result;
            i++;
            return result;
        }

        static bool Contains(int n)
        {
            for (int i = 0; i < memoizated.Length; i++)
            {
                if (memoizated[i] == n)
                {
                    return true;
                }
            }
            return false;
        }

        static int GetMemoizated(int n)
        {
            if (memoizated[n - 1] != 0)
            {
                return memoizated[n - 1];
            }

            return -1;
        }

    }
}
