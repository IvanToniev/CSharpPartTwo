
namespace CompareLexicographicaly
{
    using System;

    class CompareLexicographically
    {
        static void Main(string[] args)
        {
            string[] firstStrArr = new string[5];
            string[] secondStrArr = new string[5];

            Console.WriteLine("Enter the elements of the first string array.");

            for (int i = 0; i < firstStrArr.Length; i++)
            {
                firstStrArr[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the elements of the second string array.");

            for (int i = 0; i < secondStrArr.Length; i++)
            {
                secondStrArr[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                if (string.Compare(firstStrArr[i],secondStrArr[i])==0)
                {
                    Console.WriteLine("The two words match.");
                }
                else
                {
                    Console.WriteLine("The two words don't match.");
                }
            }
        }
    }
}
