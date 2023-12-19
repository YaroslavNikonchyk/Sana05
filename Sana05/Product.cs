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
        Currency currency = new Currency("Dolar", 36.53);
        protected int Quantity;
        protected string Producer;
        protected int Weight;

        public Product(string name, int price, Currency currency, int quantity, string producer, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.currency = currency;
            this.Quantity = quantity;
            this.Producer = producer;
            this.Weight = weight;
        }
        public double GetPriceInUAH()
        {
            return Price * currency.GetExRate();
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }
        public double GetTotalWeight()
        {
            return Weight * GetTotalPriceInUAH();
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public int GetPrice()
        {
            return Price;
        }
        public void SetPrice(int price)
        {
            this.Price = price;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public void SetQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
        public string GetProducer()
        {
            return Producer;
        }
        public void SetProducer(string producer)
        {
            Producer = producer;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public void SetWeight(int weight)
        {
            Weight = weight;
        }
    }
}
