using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Мастер и Маргарита", "Булгаков", 1967, 450, "978-5-389-07466-2");
            Magazine m = new Magazine("Наука и жизнь", "Редакция", 2024, 7, "ежемесячно");
            DVD d = new DVD("Интерстеллар", "К. Нолан", 2014, 169, "PG-13");
            Audiobook a = new Audiobook("Преступление и наказание", "Ф. Достоевский", 2020, 720, "Сергей Чонишвили");

            Console.WriteLine("Материалы библиотеки: ");
            b.DisplayInfo(); Console.WriteLine();
            m.DisplayInfo(); Console.WriteLine();
            d.DisplayInfo(); Console.WriteLine();
            a.DisplayInfo(); Console.WriteLine();

            Console.WriteLine("Проверка выдачи: ");
            b.Borrow();
            b.Borrow();
            b.Return();
            b.Return();

            Console.ReadLine();
        }
    }
}
