using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        { 
            Dictionary<string,string> dict= new Dictionary<string,string>();
            dict.Add(".NET","platform for aplications from Microsoft");
            dict.Add("CLR","managed execution environment for .NET");
            dict.Add("namespace","hierarchical organization of classes");
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();
            if (dict.ContainsKey(word))
            {
                string value=dict[word];
                Console.WriteLine(value);
            }
        }
    }
}
