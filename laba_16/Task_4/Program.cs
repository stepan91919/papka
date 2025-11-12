using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);

            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);
        }
    }
}
