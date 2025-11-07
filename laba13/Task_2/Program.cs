using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount check = new CheckingAccount("CHK001", "Иван Петров", 1000, 500);
            SavingsAccount save = new SavingsAccount("SVG002", "Анна Смирнова", 2000, 5);
            CreditAccount credit = new CreditAccount("CRD003", "Олег Иванов", -3000, 10000, new DateTime(2026, 1, 1));

            check.DisplayInfo();
            check.Withdraw(1300); // проверка овердрафта
            Console.WriteLine();

            save.DisplayInfo();
            save.AddInterest();   // начисление процентов
            Console.WriteLine();

            credit.DisplayInfo();
            credit.MakePayment(1000); // платеж по кредиту
        }
    }
}
