using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
        class Program
        {
            static void Main()
            {
                var p1 = new Point(1, 2);
                var p2 = new Point(3, 4);

                Console.WriteLine(p1 + p2);
                Console.WriteLine(p2 - p1);
            }
        }
    }