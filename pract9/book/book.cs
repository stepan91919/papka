using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value >= 1 && value <= 5000)
                    pages = value;
                else
                    Console.WriteLine("Страницы должно быть от 1 до 5000!");
            }
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

        public Book(string title) : this(title, 100) { }

        public Book() : this("Без названия", 1) { }

        public void Read()
        {
            Console.WriteLine($"Читаю книгу \"{title}\", страниц: {pages}.");
        }
    }
}
