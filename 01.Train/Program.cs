using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            int[] peopleInWagons = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());

                totalPeople += peopleInWagon;

                peopleInWagons[i] = peopleInWagon;
            }

            foreach (int peopleInWagon in peopleInWagons)
            {
                Console.Write($"{peopleInWagon} ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPeople);
        }
    }
}
