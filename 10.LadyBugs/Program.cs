using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            // check if no ladybugs
            string indexesInput = Console.ReadLine();
            if (indexesInput.Trim() == "")
            {
                return;
            }

            int[] indexes = indexesInput
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool[] positions = new bool[fieldSize];
            foreach (int index in indexes)
            {
                // put a ladybug only if it's in the field
                if (index >= 0 && index < positions.Length)
                {
                    positions[index] = true;
                }
            }

            for (; ; )
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }


                // ladybug input parameters
                int ladybugIndex = int.Parse(input.Split(' ').ToArray()[0]);
                string directionString = input.Split(' ').ToArray()[1];
                int flyLength = int.Parse(input.Split(' ').ToArray()[2]);

                bool isDirectionRight = (directionString == "right") == (flyLength > 0);
                /**
                 * right  -   left
                 * right  +   right
                 * left   -   right
                 * left   +   left
                 * */
                flyLength = Math.Abs(flyLength);


                // check if this ladybug is outside the field
                if (ladybugIndex < 0 || ladybugIndex > fieldSize)
                {
                    continue;
                }


                // check if there's actually a ladybug at the position
                if (positions[ladybugIndex] == false)
                {
                    continue; // no ladybug here
                }


                //ladybug leaves its current position
                positions[ladybugIndex] = false;

                // ladybug finds its new position
                if (isDirectionRight)
                {
                    int actualFlyLength = flyLength;
                    int newIndex;
                    for (; ; )
                    {
                        newIndex = ladybugIndex + actualFlyLength;
                        if (newIndex < positions.Length)
                        {
                            if (positions[newIndex] == true)
                            {
                                actualFlyLength += flyLength;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (newIndex < positions.Length)
                    {
                        positions[newIndex] = true;
                    }
                }
                else // direction is left
                {
                    int actualFlyLength = flyLength;
                    int newIndex;
                    for (; ; )
                    {
                        newIndex = ladybugIndex - actualFlyLength;
                        if (newIndex >= 0)
                        {
                            if (positions[newIndex] == true)
                            {
                                actualFlyLength += flyLength;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (newIndex >= 0)
                    {
                        positions[newIndex] = true;
                    }
                }
            }

            foreach (bool ladyBugPosition in positions)
            {
                int digit = 0;
                if (ladyBugPosition)
                {
                    digit = 1;
                }
                Console.Write($"{digit} ");
            }

        }
    }
}
