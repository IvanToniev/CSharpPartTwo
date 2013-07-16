using System;

namespace GetMax
{
    class GetMax
    {
        static int getMax(int varOne,int varTwo) 
        {
            if (varOne > varTwo)
            {               
                return varOne;
            }
            else
            {                
                return varTwo;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter 3 integers.");
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int biggest=getMax(getMax(firstInt,secondInt),thirdInt);

            Console.WriteLine("the biggest is {0}",biggest);

        }
    }
}
