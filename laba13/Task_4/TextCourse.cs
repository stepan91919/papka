using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    // текстовый курс
    public class TextCourse : Course
    {
        public int Chapters { get; set; }      // главы
        public int TextVolume { get; set; }    // объем текста

        public TextCourse(string title, string desc, string author, decimal price, int chapters, int volume)
            : base(title, desc, author, price)
        {
            Chapters = chapters;
            TextVolume = volume;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Глав: {Chapters}, Объем: {TextVolume} стр.");
        }

        public override void StartCourse()
        {
            Console.WriteLine($"Начато обучение по текстовому курсу '{Title}' — читаем первую главу...");
        }
    }
}
