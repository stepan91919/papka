using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3;

namespace Task3
{
    public class Laptop : IPriceable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Laptop(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}
