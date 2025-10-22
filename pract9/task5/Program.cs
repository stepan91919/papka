using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Мурзик", 9);
            Cat cat2 = new Cat("Барсик");

            cat1.speak();
            cat1.meow();
            cat1.meow();

            cat2.speak();
            cat2.meow();

            Console.ReadLine();
        }
    }

}
