using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class MyDate
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
    }
}
