using System;

namespace AscDesc
{
    class AscDesc
    {
        static void maxInSection(int[] arr,int startPosition)
        {
            int max = 0;
            for (int i = startPosition; i < arr.Length; i++)
            {
                if (max<arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

        static void SelSort(int[] arr) 
        {
            int temp, min, k;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                k = i;
                min = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        k = j;
                    }
                    temp = arr[k];
                    arr[k] = arr[i];
                    arr[i] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void SelSortDesc(int[] arr)
        {
            int temp, max, k;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                k = i;
                max = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        k = j;
                    }
                    temp = arr[k];
                    arr[k] = arr[i];
                    arr[i] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main()
        {
            Console.WriteLine("How much elements do you want your array to have?");
            int elem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your array.");
            int[] array=new int[elem];
            for (int i = 0; i < elem; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element you want to start the search from.");
            int starter = int.Parse(Console.ReadLine());
            maxInSection(array,starter);
            SelSort(array);
            SelSortDesc(array);
        }
    }
}
