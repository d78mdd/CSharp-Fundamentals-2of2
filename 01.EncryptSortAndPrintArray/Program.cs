using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());


            // collect the strings
            string[] sequenceOfStrings = new string[numberOfStrings];
            for (int i = 0; i < numberOfStrings; i++)
            {
                sequenceOfStrings[i] = Console.ReadLine();
            }


            // encrypt the strings
            string vowelsLower = "aeiouyw";
            string vowelsUpper = "AEIOUYW";
            string consonantsLower = "bcdfghjklmnpqrstvwxyz";
            string consonantsUpper = "BCDFGHJKLMNPQRSTVWXYZ";
            int[] encryptedStrings = new int[numberOfStrings];
            for (int i = 0; i < numberOfStrings; i++)
            {
                int sum = 0;

                for (int j = 0; j < sequenceOfStrings[i].Length; j++)
                {
                    char letter = sequenceOfStrings[i][j];

                    if (vowelsLower.Contains(letter) || vowelsUpper.Contains(letter))
                    {
                        sum += letter * sequenceOfStrings[i].Length;
                    }
                    else if (consonantsLower.Contains(letter) || consonantsUpper.Contains(letter))
                    {
                        sum += letter / sequenceOfStrings[i].Length;
                    }

                }

                encryptedStrings[i] = sum;
            }


            // sort the encryptions
            int[] sortedEncryptedStrings = (int[])encryptedStrings.Clone();
            for (int i = 0; i < numberOfStrings; i++)
            {
                for (int j = 0; j < numberOfStrings - 1; j++)
                {
                    int temp = sortedEncryptedStrings[j];
                    if (sortedEncryptedStrings[j] > sortedEncryptedStrings[j + 1])
                    {
                        sortedEncryptedStrings[j] = sortedEncryptedStrings[j + 1];
                        sortedEncryptedStrings[j + 1] = temp;
                    }
                }
            }


            // print the sorted encryptions
            foreach (int encryptedString in sortedEncryptedStrings)
            {
                Console.WriteLine(encryptedString);
            }

        }
    }
}
