﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimes
{
    class HowManyTimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a string");
            string str = Console.ReadLine();
            Dictionary<char, int> Letters = new Dictionary<char, int>();
            foreach (var item in str.ToLower())
            {
                if (Char.IsLetter(item))
                {
                    if (Letters.ContainsKey(item))
                    {
                        Letters[item]++;
                    }
                    else
                    {
                        Letters.Add(item, 1);
                    }
                }
            }

            foreach (var letter in Letters)
            {
                Console.WriteLine("{0} - {1,3} times found", letter.Key, letter.Value);
            }

            Console.WriteLine();
        }
    }
}
