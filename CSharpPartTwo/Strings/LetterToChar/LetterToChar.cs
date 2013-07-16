using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterToChar
{
    class LetterToChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string.");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str.Length*6);
            foreach (char ch in str)
            {
                sb.AppendFormat("\\u{0:X4}", (int)ch);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
