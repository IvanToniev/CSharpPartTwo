﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Html
{
    class HTML
    {
        static void Main(string[] args)
        {
            string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            Console.WriteLine(Regex.Replace(html, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
        }
    }
}
