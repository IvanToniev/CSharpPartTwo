using System;

namespace WorkDays
{
    class WorkDays
    {
        static DateTime[] weekends ={new DateTime(2013,3,3)};

        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime checkedDate = new DateTime(2013,3,4);
            int time = Math.Abs((today - checkedDate).Days);
            if (today>checkedDate)
            {
                today = checkedDate;
                checkedDate = DateTime.Today;
            }
            for (int i = 0; i < time; i++)
            {
                today = today.AddDays(1);
                if (today.DayOfWeek==DayOfWeek.Saturday || today.DayOfWeek==DayOfWeek.Sunday)
                {
                    time--;
                }
            }
            Console.WriteLine(time- weekends.Length);
        }
    }
}
