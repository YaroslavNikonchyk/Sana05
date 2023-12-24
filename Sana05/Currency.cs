using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Currency
    {
        protected string Name;
        protected double ExRate;
        public Currency(Currency previousCurrency)
        {
            Name= previousCurrency.Name;
            ExRate= previousCurrency.ExRate;
        }
        public Currency()
        {
            Name = "dolar";
            ExRate = 36.51;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(double exRate)
        {
            ExRate= exRate;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public double GetExRate()
        {
            return ExRate;
        }
        public void SetExRate(double exRate)
        {
            ExRate = exRate;
        }
    }
}
