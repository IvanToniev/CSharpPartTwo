using System;

namespace OperationsWithNumbers
{
    class OperationsWithNumbers
    {
        static double Min(double[] arr)
        {
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static double Max(double[] arr)
        {
            double max = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max<arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static double Sum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double Average(double[] arr)
        {
            double average = Sum(arr)/2;
            return average;
        }

        static double Product(double[] arr)
        {
            double product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will you be using?");
            int numCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a sequence of numbers number.");
            double[] arr = new double[numCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The minimum in the sequence is:{0}", Min(arr));
            Console.WriteLine("The maximum in the sequence is:{0}",Max(arr));
            Console.WriteLine("The sum of the sequence is:{0}",Sum(arr));
            Console.WriteLine("The average of the sequence is:{0}", Average(arr));
            Console.WriteLine("The product of the sequence is:{0}", Product(arr));
        }
    }
}
