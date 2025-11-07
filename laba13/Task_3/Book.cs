using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    // класс книга
    public class Book : LibraryItem
    {
        public int Pages { get; set; }     // кол-во страниц
        public string ISBN { get; set; }   // номер isbn

        public Book(string title, string author, int year, int pages, string isbn)
            : base(title, author, year)
        {
            Pages = pages;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Страниц: {Pages}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
