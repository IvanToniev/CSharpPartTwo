using System;
using System.Text;
using System.Linq;
namespace DecToHex
{
    class DecToHex
    {
        static void Main(string[] args)
        {
            int someNum = int.Parse(Console.ReadLine());
            StringBuilder hex = new StringBuilder();
            string finalNum = "";
            while (someNum > 0)
            {
                switch (someNum % 16)
                {
                    case 10:
                        hex.Append('A');
                        break;
                    case 11:
                        hex.Append('B');
                        break;
                    case 12:
                        hex.Append('C');
                        break;
                    case 13:
                        hex.Append('D');
                        break;
                    case 14:
                        hex.Append('E');
                        break;
                    case 15:
                        hex.Append('F');
                        break;
                    default:
                        hex.Append(someNum % 16);
                        break;
                }
                someNum = someNum / 16;
            }
            finalNum = hex.ToString();
            for (int i = finalNum.Length-1; i > -1; i--)
            {
                Console.Write(finalNum[i]);
            }
            Console.WriteLine();
        }
    }
}
