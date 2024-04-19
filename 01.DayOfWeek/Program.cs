using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(daysOfWeek[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }    
        }
    }
}
