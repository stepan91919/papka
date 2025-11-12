using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            var t1 = new Time(14, 35, 9);
            var t2 = new Time(9, 10, 5);

            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1[1]);

            t1[2] = 59;
            Console.WriteLine(t1);
        }
    }
}
