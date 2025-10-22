using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            p1.print();

            p1.move(5, -10);
            p1.print();

            Point p2 = new Point(150, -200);
            p2.print();

            Console.ReadLine();
        }
    }
}
