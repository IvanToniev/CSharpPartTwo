using System;

namespace HexToDec
{
    class HexToDec
    {
        static void Main(string[] args)
        {
            string someNum =Console.ReadLine();
            HexToDecimal(someNum);
        }

        static void HexToDecimal(string hex)
        {
            int decNum = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                switch (hex[i])
                {
                    case 'A': decNum += 10 * (int)Math.Pow(16, hex.Length - 1 - i); break;
                    case 'B': decNum += 11 * (int)Math.Pow(16, hex.Length - 1 - i); break;
                    case 'C': decNum += 12 * (int)Math.Pow(16, hex.Length - 1 - i); break;
                    case 'D': decNum += 13 * (int)Math.Pow(16, hex.Length - 1 - i); break;
                    case 'E': decNum += 14 * (int)Math.Pow(16, hex.Length - 1 - i); break;
                    case 'F': decNum += 15 * (int)Math.Pow(16, hex.Length - 1 - i); break;
                    default: decNum += (hex[i] - '0') * (int)Math.Pow(16, hex.Length - 1 - i); break;
                }
            }
            Console.WriteLine(decNum);
        }

    }
}
