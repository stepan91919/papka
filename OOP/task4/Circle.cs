using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Circle
    {
        private double radius;

        public Circle(double Radius)
        {
            if (Radius > 0)
            {
                radius = Radius;
            }
            else
            {
                radius = 0;
                Console.WriteLine("радиус должен быть больше 0");
            }
        }
            public void GetArea() {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }
    }
}

