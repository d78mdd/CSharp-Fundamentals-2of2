using System;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] numbersStrings = input.Split(' ');
            double[] numbers = new double[numbersStrings.Length];

            for (int i = 0; i < numbersStrings.Length; i++)
            {
                numbers[i] = double.Parse(numbersStrings[i]);
                Console.Write(numbers[i]);
                Console.Write(" => ");
                Console.WriteLine(Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            }
        }
    }
}
