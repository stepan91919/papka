using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Phone : IPriceable, IWarrantyper
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int WarrantyMonths { get; set; }

        public Phone(string name, decimal price, int warrantyMonths)
        {
            Name = name;
            Price = price;
            WarrantyMonths = warrantyMonths;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public int GetWarrantyMonths()
        {
            return WarrantyMonths;
        }
    }
}
