using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateAndTime
{
    class DateAndTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date and time. dd.mm.yyyy hh.mm.ss");
            string str = Console.ReadLine();
            DateTime date = DateTime.Parse(str);
            date = date.AddHours(6.5);
            Console.WriteLine("{0} {1}",date.ToString("dddd",new CultureInfo("bg-BG")),date);
        }
    }
}
