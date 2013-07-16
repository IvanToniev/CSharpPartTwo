using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer.");
            double someNum=0;

            try
            {
                someNum = double.Parse(Console.ReadLine());
                double something = Math.Sqrt(someNum);
                Console.WriteLine(something);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            
            finally
            {
                Console.WriteLine("Good bye.");
            }

            if (someNum<0)
            {
                throw new ArithmeticException("Invalid number!Enter a non-negative one.");
            }
        }
    }
}
