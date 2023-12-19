using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sana05
{
    public class Product
    {
        protected string Name;
        protected int Price;
        Currency currency = new Currency("Dolar", 36.5);
        protected int Quantity;
        protected string Producer;
        protected int weight;
        public double GetPriceInUAH()
        {
            return Price * currency.GetExRate();
        }
    }
}
