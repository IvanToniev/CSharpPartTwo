using System;

namespace LastDigit
{
    class LastDigit
    {
        static void FinalDigit(int number) 
        {
            int lastDig= number % 10;
            string[] arr=new string[10] {"zero","one","two","three","four","five","six","seven","eight","nine"};
            for (int i = 0; i < arr.Length; i++)
            {
                if (lastDig==i)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a number.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is:");
            FinalDigit(num);
        }
    }
}
