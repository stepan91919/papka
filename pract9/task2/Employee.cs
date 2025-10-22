using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Employee
    {
        private string name;
        private double salary;

        public Employee(string nameEmp, double salaryEmp)
        {
            name = nameEmp;
            if (salaryEmp >= 0 && salaryEmp <= 1000000)
            {
                salary = salaryEmp;
            }
            else
            {
                Console.WriteLine("зп не может быть в минусе!!!! Установлена 0)");
                salary = 0;
            }
        }

        public Employee(string nameEmp) : this(nameEmp, 50000) { }

        public void work()
        {
            Console.WriteLine($"{name} работает, зарплата: {salary}");
        }
    }
}
