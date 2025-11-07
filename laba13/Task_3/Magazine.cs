using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    // журнал
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }      // номер выпуска
        public string Frequency { get; set; }     // периодичность

        public Magazine(string title, string author, int year, int issue, string freq)
            : base(title, author, year)
        {
            IssueNumber = issue;
            Frequency = freq;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Выпуск №{IssueNumber}");
            Console.WriteLine($"Периодичность: {Frequency}");
        }
    }
}
