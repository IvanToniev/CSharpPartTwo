using System;

namespace AddPolynomials
{
    class Polynominals
    {
        static void Summer(int[] arrOne,int[] arrTwo)
        {
            int[] sumArr=new int[0];
            int sumArrLen=0;
            if (arrOne.Length>arrTwo.Length)
            {
                sumArrLen=arrOne.Length;
                sumArr = new int[sumArrLen];

                for (int i = 0; i < arrTwo.Length; i++)
                {
                    sumArr[i] = arrOne[i] + arrTwo[i];
                }

                for (int i = arrTwo.Length; i < arrOne.Length; i++)
                {
                    sumArr[i] = arrOne[i];
                }
            }
            else if(arrOne.Length<arrTwo.Length)
            {
                sumArrLen = arrTwo.Length;
                sumArr = new int[sumArrLen];

                for (int i = 0; i < arrOne.Length; i++)
                {
                    sumArr[i] = arrOne[i] + arrTwo[i];
                }

                for (int i = arrOne.Length; i < arrTwo.Length; i++)
                {
                    sumArr[i] = arrTwo[i];
                }
            }

            if (arrOne.Length==arrTwo.Length)
            {
                sumArrLen = arrOne.Length;
                sumArr = new int[sumArrLen];
                for (int i = 0; i < arrOne.Length; i++)
                {                  
                    sumArr[i] = arrOne[i] + arrTwo[i];
                }
            }

            for (int i = 0; i < sumArrLen; i++)
            {
                Console.WriteLine(sumArr[i]);
            }
        }

        static void Subtractor(int[] arrOne, int[] arrTwo)
        {
            int[] sumArr = new int[0];
            int sumArrLen = 0;
            if (arrOne.Length > arrTwo.Length)
            {
                sumArrLen = arrOne.Length;
                sumArr = new int[sumArrLen];

                for (int i = 0; i < arrTwo.Length; i++)
                {
                    sumArr[i] = arrOne[i] - arrTwo[i];
                }

                for (int i = arrTwo.Length; i < arrOne.Length; i++)
                {
                    sumArr[i] = arrOne[i];
                }
            }
            else if (arrOne.Length < arrTwo.Length)
            {
                sumArrLen = arrTwo.Length;
                sumArr = new int[sumArrLen];

                for (int i = 0; i < arrOne.Length; i++)
                {
                    sumArr[i] = arrOne[i] - arrTwo[i];
                }

                for (int i = arrOne.Length; i < arrTwo.Length; i++)
                {
                    sumArr[i] = arrTwo[i];
                }
            }

            if (arrOne.Length == arrTwo.Length)
            {
                sumArrLen = arrOne.Length;
                sumArr = new int[sumArrLen];
                for (int i = 0; i < arrOne.Length; i++)
                {
                    sumArr[i] = arrOne[i] - arrTwo[i];
                }
            }

            for (int i = 0; i < sumArrLen; i++)
            {
                Console.WriteLine(sumArr[i]);
            }
        }

        static void Main()
        {
            Console.WriteLine("How long will your polynominal be?");
            int polOneLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your first polynominal's coefficients.");
            int[] coefArr=new int[polOneLength];
            for (int i = 0; i < polOneLength; i++)
            {
                coefArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("How long will your polynominal be?");
            int polTwoLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second polynominal's coefficients.");
            int[] coefArrTwo=new int[polTwoLength];
            for (int i = 0; i < polTwoLength; i++)
            {
                coefArrTwo[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your subtracted polynominal has these coefficients.");
            //summer(coefArr,coefArrTwo);
            Summer(coefArr,coefArrTwo);
            Subtractor(coefArr,coefArrTwo);
        }
    }
}
