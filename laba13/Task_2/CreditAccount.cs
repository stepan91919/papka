using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // Кредитный счет
    public class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; set; }    // Кредитный лимит
        public DateTime RepaymentDate { get; set; } // Дата погашения

        public CreditAccount(string accountNumber, string owner, decimal balance, decimal creditLimit, DateTime repaymentDate)
            : base(accountNumber, owner, balance)
        {
            CreditLimit = creditLimit;
            RepaymentDate = repaymentDate;
        }

        // внесение платежа по кредиту
        public void MakePayment(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Платеж {amount} выполнен. Остаток долга: {Balance}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Кредитный лимит: {CreditLimit}, Дата погашения: {RepaymentDate.ToShortDateString()}");
        }
    }
}
