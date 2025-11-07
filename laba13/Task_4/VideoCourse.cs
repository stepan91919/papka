using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    // видеокурс
    public class VideoCourse : Course
    {
        public int VideoCount { get; set; }      // кол-во видео
        public int TotalDuration { get; set; }   // длительность (мин)

        public VideoCourse(string title, string desc, string author, decimal price, int count, int duration)
            : base(title, desc, author, price)
        {
            VideoCount = count;
            TotalDuration = duration;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Видео: {VideoCount}, Общая длительность: {TotalDuration} мин.");
        }

        public override void StartCourse()
        {
            Console.WriteLine($"Начато обучение по видеокурсу '{Title}' — смотрим первое видео!");
        }
    }
}
