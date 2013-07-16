using System;

namespace HowManyTimesDoesItAppear
{
    public class HowManyTimess
    {
        public static int HowMany (int number)
        {
            int[] arr=new int[10] {1,2,6,3,4,6,8,4,3,4};
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==number)
                {
                    counter++;
                }

            }
            Console.WriteLine("The number appers {0} times in the array.",counter);
            return counter;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number you wish to search for.");

            int num = int.Parse(Console.ReadLine());

            HowMany(num);
        }
    }
}
