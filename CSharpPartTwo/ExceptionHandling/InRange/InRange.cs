using System;

namespace InRange
{
    class InRange
    {
        static int ReadNumber(int start,int end)
        {
            Console.WriteLine("Enter a number.");
            int number = int.Parse(Console.ReadLine());
            if (number>end || number<start )
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }

        static void Main(string[] args)
        {
            int start = 1, end = 100;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( ReadNumber(start, end) );
            }
            
        }
    }
}
