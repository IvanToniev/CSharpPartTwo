
namespace MaximalSum
{
    using System;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how much numbers you want the maximal sum of.");
            int sumLen = int.Parse(Console.ReadLine());

            Console.WriteLine("How much elements do you want your array to have?");
            int elem = int.Parse(Console.ReadLine());

            int[] arr = new int[elem];

            for (int i = 0; i < elem; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0, maxSum = 0;

            for (int i = 0; i < elem-1; i++)
            {
                sum += arr[i];

            }

            Console.WriteLine(maxSum);

        }
    }
}
