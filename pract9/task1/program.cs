using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Библия", 1000);
            Book b2 = new Book("сказка");
            Book b3 = new Book();

            b1.read();
            b2.read();
            b3.read();

            Console.ReadLine();
        }
    }
}
