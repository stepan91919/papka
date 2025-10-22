using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {
        static void Main()
        {
            Book b1 = new Book("топ 10 удобрений для диких овощей", 2288);
            Book b2 = new Book("библия");
            Book b3 = new Book();

            b1.Read();
            b2.Read();
            b3.Read();

            b1.Pages = 6000;
            Console.ReadLine();
        }
    }
}
