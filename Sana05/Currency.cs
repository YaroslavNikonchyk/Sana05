using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Currency
    {
        public string Name { get; set; }
        public double ExRate { get; set; }
        public Currency(Currency previousCurrency)
        {
            Name = previousCurrency.Name;
            ExRate = previousCurrency.ExRate;
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
            ExRate = exRate;
        }
    }
}
