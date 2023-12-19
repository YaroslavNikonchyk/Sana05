using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate = new MyDate(2023, 04, 19, 7, 00);
        protected MyDate FinishDate = new MyDate(2023, 04, 19, 23, 00);
        protected int GetTotalTime()
        {
            int minutes1 = 0;
            int minutes2 = 0;
            minutes1 = StartDate.GetHours() * 60 + StartDate.GetMinutes();
            minutes2 = FinishDate.GetHours() * 60 + FinishDate.GetMinutes();
            return Math.Abs(minutes2 - minutes1);
        }
        protected bool IsArrivingToday()
        {
            bool arrive = false;
            if (StartDate.GetDay() == FinishDate.GetDay())
                arrive = true;
            return arrive;
        }
    }
}
