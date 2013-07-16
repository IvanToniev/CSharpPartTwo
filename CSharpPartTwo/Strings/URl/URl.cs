using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace URl
{
    class URl
    {
        static void Main(string[] args)
        {
            string uri = "http://www.devbg.org/forum/index.php";

            var fragments = Regex.Match(uri, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine(fragments[1]);
            Console.WriteLine(fragments[2]);
            Console.WriteLine(fragments[3]);
        }
    }
}
