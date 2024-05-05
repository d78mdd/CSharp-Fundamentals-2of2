using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }


        private static int GetMultipleOfEvenAndOdds(int num)
        {
            if (Math.Abs(num) < 10)
            {
                return Math.Abs(num);
            }
            else
            {
                return GetSumOfOddDigits(num) * GetSumOfEvenDigits(num);
            }
        }


        private static int GetSumOfOddDigits(int num)
        {
            string asString = Math.Abs(num).ToString();
            
            int sum = 0;

            for (int i = 0; i < asString.Length; i += 2)
            {
                sum += int.Parse(asString[i].ToString());
            }

            return sum;
        }


         private static int GetSumOfEvenDigits(int num)
        {
            string asString = Math.Abs(num).ToString();

            int sum = 0;

            for (int i = 1; i < asString.Length; i += 2)
            {
                sum += int.Parse(asString[i].ToString());
            }

            return sum;

        }
    }
}
