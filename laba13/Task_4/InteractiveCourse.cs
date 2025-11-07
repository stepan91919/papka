using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    // интерактивный курс
    public class InteractiveCourse : Course
    {
        public int Exercises { get; set; }      // количество упражнений
        public string CheckSystem { get; set; } // система проверки

        public InteractiveCourse(string title, string desc, string author, decimal price, int exercises, string check)
            : base(title, desc, author, price)
        {
            Exercises = exercises;
            CheckSystem = check;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Упражнений: {Exercises}, Проверка: {CheckSystem}");
        }

        public override void StartCourse()
        {
            Console.WriteLine($"Начато обучение по интерактивному курсу '{Title}' — выполняем задания!");
        }
    }
}
