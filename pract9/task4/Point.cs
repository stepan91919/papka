using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Point
    {

        private int x;
        private int y;


        public Point(int xValue, int yValue)
        {
            if (xValue >= -100 && xValue <= 100)
            {
                x = xValue;
            }
            else
            {
                Console.WriteLine("коорда X должна быть от -100 до 100!");
                x = 0;
            }
            if (yValue >= -100 && yValue <= 100)
            {
                y = yValue;
            }
            else
            {
                Console.WriteLine("коорда Y должна быть от -100 до 100!");
                y = 0;
            }


        }

        public void move(int dx, int dy)
        {

            x += dx;
            y += dy;
            Console.WriteLine($"Точка перемемли, теперь новые координаты ({x}, {y})");
        }

        public void print()
        {


            Console.WriteLine($"Коорды точки: X = {x}, Y = {y}");
        }
    }
}
