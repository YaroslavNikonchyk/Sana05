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
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public MyDate() {
            Year = 2023;
            Month = 7;
            Day = 19;
            Hours = 7;
            Minutes=0;
        }
        
        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int year)
        {
            Year=year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetMonth(int month)
        {
            Month=month;
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetDay(int day)
        {
            Day=day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public void SetHours(int hours)
        {
            Hours=hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public void SetMinutes(int minutes)
        {
            Minutes=minutes;
        }
        
    }
}
