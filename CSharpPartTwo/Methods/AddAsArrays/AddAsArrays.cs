using System;

namespace AddAsArrays
{
    class AddAsArrays
    {
        /*static void adder(int[] arrOne,int[] arrTwo) 
        {
            for (int i = 0,j=0; i < arrOne.Length && j<arrTwo.Length ; i++,j++)
            {
               string arrOneToString = arrOneToString + arrOne[i].ToString();
               string arrTwoToString = arrTwoToString + arrTwoToString[j].ToString();
            }
            int[] sumArr=new int[arrOne.Length + arrTwo.Length];
            for (int i = 0, j = 0,k=0; i < arrOne.Length && j < arrTwo.Length && k<sumArr.Length; i++, j++,k++)
            {
                if (arrOne[i]+arrTwo[j]>9)
                {
                    sumArr[k] = (arrOne[i] + arrTwo[j]) % 10;
                    sumArr[k + 1] += (arrOne[i] + arrTwo[j]) / 10;
                }
                else if (arrOne[i] + arrTwo[j] <= 9) 
                {
                    sumArr[k] = arrOne[i] + arrTwo[j];
                }
            }
            for (int i = 0; i < sumArr.Length; i++)
            {
                Console.WriteLine(sumArr[i]);
            }
        }*/

        static void Main()
        {
            Console.WriteLine("How many digits do you want your first number to have.");
            int firstArrLen=int.Parse(Console.ReadLine());
            Console.WriteLine("How many digits do you want your second number to have.");
            int secondArrLen=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your 1st array.");
            int[] firstArr=new int[firstArrLen];

            for (int i = 0; i < firstArrLen; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());            
            }

            Console.WriteLine("Enter your second array.");
            int[] secondArr=new int[secondArrLen];
            for (int i = secondArrLen; i > 0; i--)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            //adder(firstArr,secondArr);

        }
    }
}
