using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = allNumbers.Length;

            int allSubsequencesCount = 0;

            string[] allSubSequences;


            //get all subsequences - but only consecutive
            {
                // count all subsequences

                // get a starting number
                for (int i = 0; i < n; i++)
                {
                    // get ending number
                    for (int j = i; j < n; j++)
                    {
                        // get all numbers from starting to ending number - construct 1 subsequence
                        allSubsequencesCount++;
                        //Console.Write(allSubsequencesCount + "  ");
                        for (int k = i; k <= j; k++)
                        {
                            //Console.Write(allNumbers[k] + " ");
                        }
                        //Console.WriteLine();

                    }
                    //Console.WriteLine();
                }


                // get them
                allSubSequences = new string[allSubsequencesCount];
                int subSequenceIndex = 0;

                // get a starting number
                for (int i = 0; i < n; i++)
                {
                    // get ending number
                    for (int j = i; j < n; j++)
                    {
                        // get all numbers from starting to ending number - construct 1 subsequence
                        for (int k = i; k <= j; k++)
                        {
                            allSubSequences[subSequenceIndex] += allNumbers[k] + " ";
                        }
                        Console.WriteLine(allSubSequences[subSequenceIndex]);
                        subSequenceIndex++;

                    }
                }
            }





            //collect only the increasing ones


            //get the longest one

        }
    }
}
