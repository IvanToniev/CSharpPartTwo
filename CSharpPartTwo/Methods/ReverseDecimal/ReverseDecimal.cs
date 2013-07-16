using System;

namespace ReverseDecimal
{
    class ReverseDecimal
    {      
        static void Reverse(decimal number)
        {
            decimal nextNum = number;
            decimal reminder = 0;
            decimal reversed = 0;
            
            while (nextNum > 0)
            {
                reminder= nextNum % 10;
                reversed = reversed * 10 + reminder;
                nextNum = Math.Floor(nextNum / 10);
            }

            Console.WriteLine(reversed);           
        }

        static void Main()
        {
            Console.WriteLine("Enter your decimal number.");

            decimal number = decimal.Parse(Console.ReadLine());

            Reverse(number);
        }
    }
}
