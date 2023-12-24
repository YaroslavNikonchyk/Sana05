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
        protected MyDate StartDate;
        protected MyDate FinishDate;
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
            StartDate = new MyDate(2023,4,19,12,00);
            FinishDate = new MyDate(2023, 4, 19, 20, 00);
        }
        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
        public Airplane(string startCity,string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }
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
        public string GetStartCity()
        {
            return StartCity;
        }
        public void SetStartCity(string city)
        {
            StartCity = city;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public void SetFinishCity(string city)
        {
            FinishCity = city;
        }
        public MyDate GetStartDate()
        {
            return StartDate;
        }
        public void SetStartDate(MyDate startDate)
        {
            StartDate = startDate;
        }
        public MyDate GetFinishDate()
        {
            return FinishDate;
        }
        public void SetFinishDate(MyDate finishDate)
        {
            FinishDate = finishDate;
        }
    }
}
