using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Shapes
{
    // Абстрактный класс
    public abstract class Shape
    {
        public abstract string Draw();
    }

    // Класс Круг
    public class Circle : Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }

    // Класс Треугольник
    public class Triangle : Shape
    {
        public override string Draw()
        {
            return "Рисую треугольник";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Triangle() };

            foreach (var s in shapes)
                Console.WriteLine(s.Draw());

            Console.ReadLine();
        }
    }
}
