using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            VideoCourse v = new VideoCourse("C# с нуля", "Основы языка и ООП", "Иван Петров", 1999, 24, 600);
            TextCourse t = new TextCourse("История ИТ", "Развитие технологий", "Анна Смирнова", 899, 8, 120);
            InteractiveCourse i = new InteractiveCourse("Алгоритмы", "Практика и задачи", "Дмитрий К.", 1499, 15, "Автопроверка");

            Console.WriteLine("Каталог курсов: ");
            v.DisplayInfo(); Console.WriteLine();
            t.DisplayInfo(); Console.WriteLine();
            i.DisplayInfo(); Console.WriteLine();

            Console.WriteLine("начало обучения: ");
            v.StartCourse();
            t.StartCourse();
            i.StartCourse();

            Console.ReadLine();
        }
    }
}
