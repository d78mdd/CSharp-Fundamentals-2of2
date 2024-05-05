using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            GetIntermediateCharacters(c1, c2);
        }

        private static void GetIntermediateCharacters(char c1, char c2)
        {
            if (c1 > c2)
            {
                char temp = c1;
                c1 = c2;
                c2 = temp;
            }

            for (char i = (char)(c1 + 1); i < c2; i++)
            {
                Console.Write(i + " ");
            }
        }

    }
}
