using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    // базовый класс
    public abstract class Course
    {
        public string Title { get; set; }      // название
        public string Description { get; set; } // описание
        public string Author { get; set; }      // автор курса
        public decimal Price { get; set; }      // цена

        public Course(string title, string desc, string author, decimal price)
        {
            Title = title;
            Description = desc;
            Author = author;
            Price = price;
        }

        // общий метод
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Курс: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Цена: {Price} руб.");
        }

        // метод обучения
        public abstract void StartCourse();
    }
}
