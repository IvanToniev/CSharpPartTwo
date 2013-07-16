using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string someString = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string reverse = "";
            for (int i = someString.Length-1; i >= 0; i--)
            {
                sb.Append(someString[i]);
            }
            reverse = sb.ToString();
            Console.WriteLine(reverse);
        }
    }
}
