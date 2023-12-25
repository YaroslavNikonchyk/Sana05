using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class MyDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public MyDate(MyDate previousDate)
        {
            Year = previousDate.Year;
            Month = previousDate.Month;
            Day = previousDate.Day;
            Hours = previousDate.Hours;
            Minutes = previousDate.Minutes;
        }
        public MyDate()
        {
            Year = 2023;
            Month = 7;
            Day = 19;
            Hours = 7;
            Minutes = 0;
        }
        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
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
