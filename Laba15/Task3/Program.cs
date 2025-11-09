using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            // список техники
            List<object> products = new List<object>()
        {
            new Phone("Samsung", 25000m, 12),
            new Laptop("Acer", 40000m),
            new Phone("iPhone", 80000m, 24)
        };

            decimal total = 0;

            Console.WriteLine("Магазин техники:\n");

            foreach (var item in products)
            {
                // товар можно оценить
                if (item is IPriceable priceable)
                {
                    decimal price = priceable.GetPrice();
                    total += price;
                    Console.WriteLine($"{item.GetType().Name}: {price} руб.");
                }

                //гарантия
                if (item is IWarrantyper warrantable)
                {
                    Console.WriteLine($"  Гарантия: {warrantable.GetWarrantyMonths()} мес.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Общая стоимость всех товаров: {total} руб.");
        }
    }
}
