
namespace Initialize
{
    using System;

    class Initialize
    {
        static void Main()
        {
            int[] arr=new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i*5;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
