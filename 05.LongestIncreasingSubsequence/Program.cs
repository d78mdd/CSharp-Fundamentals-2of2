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

            int continuousSubsequencesCount = 0;

            string[] continuousSubSequences;

            for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {
                    Console.WriteLine(allNumbers[i] + " " + allNumbers[j]);
                }


            }
            return;
            //get all continuous subsequences
            {
                // count them

                // get a starting number
                for (int i = 0; i < n; i++)
                {
                    // get ending number
                    for (int j = i; j < n; j++)
                    {
                        // get all numbers from starting to ending number - construct 1 subsequence
                        continuousSubsequencesCount++;
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
                continuousSubSequences = new string[continuousSubsequencesCount];
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
                            continuousSubSequences[subSequenceIndex] += allNumbers[k] + " ";
                        }
                        Console.WriteLine(continuousSubSequences[subSequenceIndex]);
                        subSequenceIndex++;

                    }
                }
            }





            //get all subsequences - instead including scattered ones (non-continuous)
            /* 
             * 1234 >
             * 
             * 1
             * 12
             * 123
             * 1234
             * 
             * 124
             * 
             * 13
             * 134
             * 
             * 14
             * 
             * 2
             * 23
             * 234
             * 
             * 24
             * 
             * 3
             * 
             * 34
             * 
             * 4
             * 
             * 
             * 
             * 12345 >
             * 
             * 1
             * 12
             * 123
             * 1234
             * 12345
             * 
             * 1235
             * 
             * 124
             * 1245
             * 
             * 125
             * 
             * 13
             * 134
             * 1345
             * 135
             * 
             * 14
             * 145
             * 
             * 15
             * 
             * 2
             * 23
             * 234
             * 2345
             * 
             * 235
             * 
             * 24
             * 245
             * 25
             * 
             * 3
             * 34
             * 345
             * 
             * 35
             * 
             * 45
             * 
             * 5
             */
            for (int i = 0; i < n; i++)
            {
                //GetPermutationsFor(allNumbers[], from, to);


            }


            //collect only the increasing ones


            //get the longest one

        }


        /*
         * 1234 >
         * 
         * 1
         * 12
         * 123
         * 1234
         * 124
         * use appending?
         * 13
         * 134
         * 14
         * 
         * 
         * GetPermutationsFor(arr, from + 1, to);
             * 2
             * 23
             * 234
             * 24
             * 
             * GetPermutationsFor(arr, from + 1, to);
                 * 3
                 * 34
                 * 
                 * GetPermutationsFor(arr, from + 1, to);
                     * 4
                     * 
         */
        public static void GetPermutationsFor(int[] arr, int from, int to)
        {
            // get continuous permutations from [from] to [to]
            // shall this include nonconinuous?

            GetPermutationsFor(arr, from + 1, to);
        }

    }
}
