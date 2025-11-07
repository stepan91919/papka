using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    // базовый класс для всех материалов
    public abstract class LibraryItem
    {
        public string Title { get; set; }      // название
        public string Author { get; set; }     // автор
        public int Year { get; set; }          // год издания
        public bool IsAvailable { get; set; }  // доступность

        public LibraryItem(string title, string author, int year, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }

        // инфо о материале
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Доступна: {(IsAvailable ? "Да" : "Нет")}");
        }

        // взять материал
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"'{Title}' выдан.");
            }
            else
            {
                Console.WriteLine($"'{Title}' уже выдан.");
            }
        }

        // вернуть материал
        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"'{Title}' возвращен в библиотеку.");
            }
            else
            {
                Console.WriteLine($"'{Title}' уже в библиотеке.");
            }
        }
    }
}
