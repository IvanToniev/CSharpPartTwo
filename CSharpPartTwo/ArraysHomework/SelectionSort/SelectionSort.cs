using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much elements do you want your array to have?");
            int elem=int.Parse(Console.ReadLine());
            int[] arr = new int[elem];
            Console.WriteLine("Enter your elements.");

            for (int i = 0; i < elem; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temp, min, k;

            for (int i = 0; i < elem-1; i++)
            {
                k = i;
                min = arr[i];
                for (int j = i+1; j < elem; j++)
                {
                    if (arr[j]<min)
                    {
                        min=arr[j];
                        k = j;
                    }
                    temp = arr[k];
                    arr[k] = arr[i];
                    arr[i] = temp;
                }
            }

            for (int i = 0; i < elem; i++)
			{
                Console.WriteLine(arr[i]);
			}
        }
    }
}
