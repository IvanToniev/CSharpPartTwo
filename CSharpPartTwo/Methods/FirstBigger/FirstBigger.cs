using System;

namespace FirstBigger
{
    class FirstBigger
    {
        static int BiggerThanTheNeighbour(int[] arr) 
        {
            int index = 0;
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }

        static void Main()
        {
           int[] array=new int[10] {0,0,0,0,2,5,7,7,8,9};
           Console.WriteLine(BiggerThanTheNeighbour(array));
        }
    }
}
