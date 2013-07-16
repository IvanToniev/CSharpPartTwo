using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AlphabeticalOrder
{
    class AlphaOrder
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your words separated with spaces");
            string str = Console.ReadLine();

            var split = new List<string>();
            foreach (Match word in Regex.Matches(str, @"\w+"))
            {
                split.Add(word.Value);
            }
            split.Sort();
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }
        }
    }
}
