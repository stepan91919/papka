using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Laptop laptop1 = new Laptop("Dell", 16, 85);
                laptop1.powerOn();
                laptop1.work();

                Laptop laptop2 = new Laptop("HP", 0, 50); 
                laptop2.powerOn();
                laptop2.work();

                Console.ReadLine();
            }
        }
    }
}