using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text.");
            string text = Console.ReadLine();

            string[] forbidden=new string[3] {"PHP","CLR","Microsoft"};
            for (int i = 0; i < forbidden.Length; i++)
            {
                forbidden[i] = forbidden[i].Trim();
                text = text.Replace(forbidden[i],new string('*',forbidden[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
