using System;
using System.Collections.Generic;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string someNum = Console.ReadLine();
            int decNum = 0;
            for (int i = 0; i < someNum.Length; i++)
			{
                decNum = decNum << 1;
                if (someNum[i]=='1')
                {
                    decNum = decNum ^ 1;
                }
			}
            Console.WriteLine(decNum);
        }
    }
}
