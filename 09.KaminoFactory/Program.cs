using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencesLength = int.Parse(Console.ReadLine());


            int[] bestSequence = new int[sequencesLength];
            int bestSequenceSum = 0;
            int bestSequenceIndex = 1; // because we know we will have at least one sequence

            int bestSequenceSubSequenceLength = 0;
            int bestSequenceSubSequenceStartIndex = -1;


            int currentIndex = 0;


            for (; ; )
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                // keep track of number of sequences entered
                currentIndex++;


                // initialize currentSequence
                int[] currentSequence;
                {
                    string currentSequenceString = input;
                    int exclamationsCount = 0;
                    foreach (char c in currentSequenceString)   // although exclamationsCount will always be int sequencesLength / 2 
                    {
                        if (c == '!')
                        {
                            exclamationsCount++;
                        }
                    }
                    currentSequence = new int[currentSequenceString.Length - exclamationsCount];
                    int i = 0;
                    foreach (char c in currentSequenceString)
                    {
                        if (c == '1')
                        {
                            currentSequence[i] = 1;
                            i++;
                        }
                        else if (c == '0')  // although 0 is already assigned since it's default value
                        {
                            currentSequence[i] = 0;
                            i++;
                        }
                    }
                }

                int currentSequenceSum = currentSequence.Sum();

                int currentSequenceCurrentSubSequenceLength = 0;
                int currentSequenceCurrentSubSequenceStartIndex = -1;
                
                int currentSequenceLongestSubSequenceLength = 0;
                int currentSequenceLongestSubSequenceStartIndex = -1;


                // initialize using the first item if needed
                if (currentSequence[0] == 1)
                {
                    currentSequenceCurrentSubSequenceLength++;
                    currentSequenceCurrentSubSequenceStartIndex = 0;

                    currentSequenceLongestSubSequenceLength = currentSequenceCurrentSubSequenceLength;
                    currentSequenceLongestSubSequenceStartIndex = currentSequenceCurrentSubSequenceStartIndex;
                }
                // continue processing from 2nd to last items
                for (int j = 1; j < currentSequence.Length; j++)
                {
                    if (currentSequence[j] == 1)
                    {
                        currentSequenceCurrentSubSequenceLength++;
                        if (currentSequence[j - 1] == 0)
                        {
                            currentSequenceCurrentSubSequenceStartIndex = j;
                        }
                    }
                    else // currentSequence[j] == 0
                    {
                        currentSequenceCurrentSubSequenceLength = 0;
                        currentSequenceCurrentSubSequenceStartIndex = -1;
                    }

                    if (currentSequenceCurrentSubSequenceLength > currentSequenceLongestSubSequenceLength)
                    {
                        currentSequenceLongestSubSequenceLength = currentSequenceCurrentSubSequenceLength;
                        currentSequenceLongestSubSequenceStartIndex = currentSequenceCurrentSubSequenceStartIndex;
                    }
                }


                // check if the current longest is a new best
                bool updateBestSequence = false;
                if (currentSequenceLongestSubSequenceLength > bestSequenceSubSequenceLength)
                {
                    updateBestSequence = true;
                }
                else if (currentSequenceLongestSubSequenceLength == bestSequenceSubSequenceLength)
                {

                    if (currentSequenceLongestSubSequenceStartIndex < bestSequenceSubSequenceStartIndex)
                    {
                        updateBestSequence = true;
                    }
                    else if (currentSequenceLongestSubSequenceStartIndex == bestSequenceSubSequenceStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            updateBestSequence = true;
                        }
                    }
                }

                // update if new best was found
                if (updateBestSequence)
                {
                    bestSequence = currentSequence;
                    bestSequenceIndex = currentIndex;
                    bestSequenceSum = currentSequenceSum;

                    bestSequenceSubSequenceLength = currentSequenceLongestSubSequenceLength;
                    bestSequenceSubSequenceStartIndex = currentSequenceLongestSubSequenceStartIndex;
                }

            }

            // construct best sequence string
            string bestSequenceString = "";
            foreach (int num in bestSequence)
            {
                bestSequenceString += num;
                bestSequenceString += " ";
            }
            bestSequenceString = bestSequenceString.Trim();

            // output
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine($"{bestSequenceString}");

        }
    }
}
