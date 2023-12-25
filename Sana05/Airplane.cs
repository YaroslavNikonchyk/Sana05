using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public MyDate StartDate { get; set; }
        public MyDate FinishDate { get; set; }
        public Airplane(Airplane previousAirplane)
        {
            StartCity = previousAirplane.StartCity;
            FinishCity = previousAirplane.FinishCity;
            StartDate = previousAirplane.StartDate;
            FinishDate = previousAirplane.FinishDate;
        }
        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Varshava";
            StartDate = new MyDate(2023, 4, 19, 12, 00);
            FinishDate = new MyDate(2023, 4, 19, 20, 00);
        }
        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
        public int GetTotalTime()
        {
            int minutes1 = 0;
            int minutes2 = 0;
            int minutes3 = 0;
            minutes1 = StartDate.Hours * 60 + StartDate.Minutes;
            minutes2 = FinishDate.Hours * 60 + FinishDate.Minutes;
            minutes3 = (FinishDate.Day - StartDate.Day) * 24*60;
            return  Math.Abs(minutes3 + minutes2 - minutes1);
        }
        public bool IsArrivingToday()
        {
            bool arrive = false;
            if (StartDate.Day == FinishDate.Day)
                arrive = true;
            return arrive;
        }
    }
}
