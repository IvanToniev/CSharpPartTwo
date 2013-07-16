using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Consecutive
{
    class Consecutive
    {
        static void Main(string[] args)
        {
            string str = "aaaaabbbbbcdddeeeedssaa";

            Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
        }
    }
}
