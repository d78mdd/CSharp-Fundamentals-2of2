using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            int longestSequence = 0;
            int longestSequenceElement = -1;

            int currentSequence = 0;
            int currentSequenceElement = -1;

            if (array.Length > 0)
            {
                currentSequence++;
                longestSequence = currentSequence;
                currentSequenceElement = array[0];
                longestSequenceElement = currentSequenceElement;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                    currentSequenceElement = array[i];
                }

                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    longestSequenceElement = currentSequenceElement;
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write($"{longestSequenceElement} ");
            }
        }
    }
}
