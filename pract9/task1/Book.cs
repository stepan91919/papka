using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Book
    {
        private string title;
        private int pages;

        public Book(string bookTitle, int bookPages)
        {

            title = bookTitle;
            if (bookPages >= 1 && bookPages <= 5000)
            {

                pages = bookPages;
            }
            else
            {
                Console.WriteLine("Страниц должно быть от 1 до 5000!");
            }
        }

        public Book(string bookTitle) : this(bookTitle, 100) { }


        public Book() : this("без названия", 1) { }

        public void read()
        {

            Console.WriteLine($"читаю книгу с названием: \"{title}\", c количеством страниц страниц: {pages}");
        }
    }
}
