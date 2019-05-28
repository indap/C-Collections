using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            // Console.WriteLine("Which day do you want to display?");
            // Console.WriteLine("(Note: 0-indexed array) > ");
            // int iDay = int.Parse(Console.ReadLine());

            // string chosenDay = daysOfWeek[iDay-1];
            // Console.WriteLine($"That day is {chosenDay}");

            Console.WriteLine("Before:");
            foreach(string day in daysOfWeek)
                Console.WriteLine(day);
            
            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nAfter:");
            foreach(string day in daysOfWeek)
                Console.WriteLine(day);
        }
    }
}
