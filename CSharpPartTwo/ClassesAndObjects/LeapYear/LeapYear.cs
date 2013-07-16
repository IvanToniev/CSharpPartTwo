using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year you want to check.");
            int year = int.Parse(Console.ReadLine());           
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
