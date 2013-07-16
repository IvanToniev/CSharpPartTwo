using System;

namespace StringOfNumbersSum
{
    class StringOfNumbersSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string.");
            string userString = Console.ReadLine();
            userString = userString.Trim();
            int sum = 0;
            string[] inParts = userString.Split(' ');
            foreach (var number in inParts)
            {
                sum += int.Parse(number);
            }
            Console.WriteLine(sum);
        }
    }
}
