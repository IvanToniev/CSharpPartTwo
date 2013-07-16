using System;

namespace MaxIncreasingSeq
{
    class MaxIncreasingSeq
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 10, 9, 12, 3, 4, 5 };

            int len = 1, bestLen = 1, startElem = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] < arr[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestLen = len;
                        startElem = i - len + 1;
                    }
                    len = 1;
                }
            }
            for (int i = startElem; i < startElem + bestLen; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
