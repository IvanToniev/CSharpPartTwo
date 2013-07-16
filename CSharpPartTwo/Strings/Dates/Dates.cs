using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Dates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date one. dd.mm.yyyy");
            string dOne = Console.ReadLine();
            Console.WriteLine("Enter date two.  dd.mm.yyyy");
            string dTwo = Console.ReadLine();

            DateTime dateOne = DateTime.Parse(dOne);
            DateTime dateTwo = DateTime.Parse(dTwo);

            Console.WriteLine((dateTwo-dateOne).TotalDays);

        }
    }
}
