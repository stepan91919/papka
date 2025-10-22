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
            Cat cat1 = new Cat("Барсик", 3, "серый");
            cat1.makeSound();
            cat1.meow();

            Cat cat2 = new Cat("Мурка", 55, "рыжий"); 
            cat2.makeSound();
            cat2.meow();

            Console.ReadLine();
        }
    }
}
