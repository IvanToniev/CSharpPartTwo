using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterixFill
{
    class AsterixFill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string.");
            string str = Console.ReadLine();

            if (str.Length<20)
            {
                for (int i = str.Length; i < 20; i++)
                {
                    str = str + '*';
                }
                Console.WriteLine(str);
            }
            
            if (str.Length>20)
            {
                Console.WriteLine("Bad input.The string can't be bigger than 20 characters.");
            }
        }
    }
}
