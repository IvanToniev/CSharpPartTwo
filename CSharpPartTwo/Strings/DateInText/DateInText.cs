using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DateInText
{
    class DateInText
    {
        static void Main(string[] args)
        {
            string str = "some text to fill 27.03.1993 and some more text and a fake date 26.30.1213 asdasd 03.27";
            DateTime date;
            foreach (Match item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}
