﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LastProblem
{
    class LastProblem
    {
        static void Main(string[] args)
        {
            string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            int countOfOpenedTags = 0;
            bool hasPrinted = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    countOfOpenedTags++;

                    if (hasPrinted == true)
                    {
                        Console.Write(' ');
                        hasPrinted = false;
                    }
                    continue;
                }
                if (text[i] == '>')
                {
                    countOfOpenedTags--;
                    continue;
                }
                if (countOfOpenedTags == 0)
                {
                    Console.Write(text[i]);
                    hasPrinted = true;
                }
            }
            Console.WriteLine();
        }
    }
}
