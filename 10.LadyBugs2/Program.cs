using System;
using System.Linq;

namespace _10.LadyBugs2
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
                if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
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

                // ladybug searches for its new position
                int actualFlyLength = flyLength;
                int newIndex;
                for (; ; )
                {
                    if (isDirectionRight)
                    {
                        newIndex = ladybugIndex + actualFlyLength;
                    }
                    else // direction is left
                    {
                        newIndex = ladybugIndex - actualFlyLength;
                    }
                    if (newIndex >= 0 && newIndex < positions.Length) // if the new position is in the field
                    {
                        if (positions[newIndex] == true) // if there's a ladybug there
                        {
                            actualFlyLength += flyLength;
                        }
                        else // there's no ladybug there, will land there
                        {
                            positions[newIndex] = true; // the bug lands
                            break;
                        }
                    }
                    else // the new position is not within the field, the ladybug flew away
                    {
                        break;
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
