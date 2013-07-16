

namespace CompareTwoArrays
{
    using System;

    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];

            Console.WriteLine("Enter the elements of the first array.");

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of the second array.");

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (firstArray[i]==secondArray[i])
                {
                    Console.WriteLine("The elements of the two arrays with index {0} are equal.",i);
                }
                else
                {
                    Console.WriteLine("The elements of the the two arrays with index {0} are not equal.",i);
                }
            }
        }
    }
}
