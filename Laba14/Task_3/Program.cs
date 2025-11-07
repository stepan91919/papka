using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Food
{
    // базовый класс
    public class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }

    // класс Пицца
    public class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }

    // класс Бургер
    public class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };

            foreach (var f in lunch)
                f.Eat();

            Console.ReadLine();
        }
    }
}
