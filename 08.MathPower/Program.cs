using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            MathPower(n, p);
        }

        static void MathPower(int n, int p)
        {
            Console.Write(Math.Pow(n, p));
        }
    }
}
