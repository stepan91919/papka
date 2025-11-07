using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    // аудиокнига
    public class Audiobook : LibraryItem
    {
        public int Length { get; set; }       // длительность (мин)
        public string Narrator { get; set; }  // диктор

        public Audiobook(string title, string author, int year, int length, string narrator)
            : base(title, author, year)
        {
            Length = length;
            Narrator = narrator;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Длительность: {Length} мин");
            Console.WriteLine($"Диктор: {Narrator}");
        }
    }
}
