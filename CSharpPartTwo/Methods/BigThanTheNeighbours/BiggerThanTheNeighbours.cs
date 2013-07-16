using System;

namespace BigThanTheNeighbours
{
    class BiggerThanTheNeighbours
    {
        static void CheckNeighbours(int position) 
        {
            int[] arr=new int[10] {0,1,2,3,4,3,6,7,8,9};

            
            if (position==0)
            {
                if (arr[position] > arr[position + 1])
                {
                    Console.WriteLine("The number at position {0} is bigger than its neighbour.", position);
                }
                else
                {
                    Console.WriteLine("The number at position {0} is smaller than its neighbour.",position);
                }
            }
             else if (position==arr[arr.Length-1])
            {
                if (arr[position] > arr[position - 1])
                {
                    Console.WriteLine("The number at position {0} is bigger than its neighbour.", position);
                }
                else
                {
                    Console.WriteLine("The number at position {0} is smaller than its neighbour.", position);
                }
            }

            else if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                Console.WriteLine("The number at position {0} is bigger than its neighbours.", position);
            }
            else if (arr[position] > arr[position - 1] && arr[position] < arr[position + 1])
            {
                Console.WriteLine("The number at position {0} is smaller than its right neighbour and bigger than its left.", position);
            }
            else if (arr[position] < arr[position - 1] && arr[position] < arr[position + 1])
            {
                Console.WriteLine("The number at position {0} is smaller than its neighbours.", position);
            }
            else if (arr[position] < arr[position - 1] && arr[position] > arr[position + 1] )
            {
                Console.WriteLine("The number at position {0} is bigger than its right neighbour and smaller than its left.", position);
            }
            
        }
        

        static void Main()
        {
            Console.WriteLine("Enter the position you want to check.");
            int pos = int.Parse(Console.ReadLine());
            CheckNeighbours(pos);
        }
    }
}
