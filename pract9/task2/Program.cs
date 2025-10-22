using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Иван", 80000);
            Employee e2 = new Employee("Анна");

            e1.work();
            e2.work();

            Console.ReadLine();
        }
    }
}

