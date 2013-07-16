using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Palindrom
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            string str = "abba lamal asdasd b00b kon4e kajdsa baab lol cicki";
            bool state = true;

            foreach (Match item in Regex.Matches(str, @"\w+"))
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - 1 - i])
                    {
                        state = false;
                    }
                    else { state = true; }
                }
                if (state == true)
                {
                    Console.WriteLine(item);
                }
            }
            foreach (Match item in Regex.Matches(str, @"\b(?<n>.)+.?(?<-n>\k<n>)+(?(n)(?!))\b"))
            {
                Console.WriteLine(item);
            }

        }
    }
}
