using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In
{
    class In
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string.");
            string myStr = Console.ReadLine();
            string current = "";
            int counter = 0;
            for (int i = 0; i < myStr.Length-1; i++)
            {
                current = myStr[i].ToString()+myStr[i+1].ToString();
                if (string.Compare(current,"in",true)==0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
