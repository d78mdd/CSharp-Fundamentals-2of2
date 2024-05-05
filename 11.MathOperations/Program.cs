using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, @operator, num2));
        }

        private static double Calculate(int a, string @operator, int b)
        {
            switch (@operator)
            {
                case "+":
                    return a + b;
                    break;
                case "-":
                    return a - b;
                    break;
                case "/":
                    return a / b;
                    break;
                case "*":
                    return a * b;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
