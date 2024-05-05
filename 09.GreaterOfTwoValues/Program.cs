using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        int v1 = int.Parse(Console.ReadLine());
                        int v2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(v1, v2));
                    }
                    break;
                case "char":
                    {
                        char v1 = char.Parse(Console.ReadLine());
                        char v2 = char.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(v1, v2));
                    }
                    break;
                case "string":
                    {
                        string v1 = Console.ReadLine();
                        string v2 = Console.ReadLine();
                        Console.WriteLine(GetMax(v1, v2));
                    }
                    break;
                default:
                    break;
            }

        }

        static int GetMax(int v1, int v2)
        {
            return Math.Max(v1, v2);
        }

        static char GetMax(char v1, char v2)
        {
            return (char)Math.Max((int)v1, (int)v2);
        }

        static string GetMax(string v1, string v2)
        {
            int sum1 = 0;
            foreach (char c in v1)
            {
                sum1 += c;
            }
            int sum2 = 0;
            foreach (char c in v2)
            {
                sum2 += c;
            }
            if (sum1 > sum2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }
    }
}
