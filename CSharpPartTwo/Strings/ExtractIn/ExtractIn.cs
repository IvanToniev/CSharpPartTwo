using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractIn
{
    class ExtractIn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentences.");
            string sent = Console.ReadLine();

            string[] spl=sent.Split('.');
            for (int i = 0; i < spl.Length; i++)
            {
                if (spl[i].IndexOf("in")>-1)
                {
                    Console.WriteLine(spl[i]+'.');
                }
            }

            
        }
    }
}
