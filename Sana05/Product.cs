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
        public string Name { get; set; }
        public int Price { get; set; }
        public Currency currency { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public int Weight { get; set; }
        public Product(Product previousProduct)
        {
            Name = previousProduct.Name;
            Price = previousProduct.Price;
            currency = previousProduct.currency;
            Quantity = previousProduct.Quantity;
            Producer = previousProduct.Producer;
            Weight = previousProduct.Weight;
        }
        public Product()
        {
            Name = "Car";
            Price = 10000;
            currency = new Currency("Dolar", 36.53);
            Quantity = 1;
            Producer = "Crysler";
            Weight = 1500;
        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
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
            return Price * currency.ExRate;
        }
        public double GetTotalPriceInUAH()
        {
            return Quantity * GetPriceInUAH();
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
