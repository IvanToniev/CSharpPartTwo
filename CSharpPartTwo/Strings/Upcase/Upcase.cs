using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcase
{
    class Upcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string.");
            string input = Console.ReadLine();
             
            int startIndex = 0, endIndex = 0;
            for (int i = 0; i < input.Length-8; i++)
            {
                
                if (input.Substring(i, 8) == "<upcase>")
                {
                    startIndex = i + 8;
                    i = startIndex;
                }
                if (input.Substring(i, 9) == "</upcase>")
                {
                    endIndex = i;
                    int len = endIndex - startIndex;
                    string upc = input.Substring(startIndex, len).ToUpper();
                    input = input.Remove(startIndex,len);
                    input = input.Insert(startIndex,upc);
                    input = input.Remove(startIndex-8,8);
                    input = input.Remove(endIndex-8,9);

                }
            }
            Console.WriteLine(input);
        }
    }
}
