using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace NonameThing_1
{
    public class BUdate
    {
        DateTime time;
        DayOfWeek dow;
        readonly CultureInfo culture = new CultureInfo("ru-RU");

        public BUdate(DateTime time)
        {
            this.time = time;
            this.dow = time.DayOfWeek;
        }

        public void SetTime(DateTime time)
        {
            this.time = time;
        }

        public void SetDow(DayOfWeek dow)
        {
            this.dow = dow;
        }

        public DateTime GetTime()
        {
            return time;
        }

        public DayOfWeek GetDow()
        {
            return dow;
        }

        public int GetDowInt()
        {
            switch (dow)
            {
                case DayOfWeek.Sunday:
                    return 7;
                case DayOfWeek.Monday:
                    return 1;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Friday:
                    return 5;
                case DayOfWeek.Saturday:
                    return 6;
            };
            return 0;
        }

        public override string ToString()
        {
            return time.ToShortTimeString() + " " + culture.DateTimeFormat.GetDayName(dow);
        }
    }
}
