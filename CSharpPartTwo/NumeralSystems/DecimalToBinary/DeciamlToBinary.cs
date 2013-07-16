using System;
using System.Collections.Generic;
namespace DecimalToBinary
{
    class DeciamlToBinary
    {
        static void Main()
        {
            int someNum = int.Parse(Console.ReadLine());
            List<int> binNum = new List<int>();
            while (someNum>0)
            {
                binNum.Add(someNum%2);
                someNum = someNum / 2;
            }
            binNum.Reverse();
            for (int i = 0; i < binNum.Count; i++)
            {
                Console.Write("{0}",binNum[i]);
            }
            Console.WriteLine();
        }
    }
}
