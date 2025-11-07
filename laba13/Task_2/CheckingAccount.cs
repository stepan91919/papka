using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // Текущий счет с овердрафтом
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; } // лимит овердрафта


        public CheckingAccount(string accountNumber, string owner, decimal balance, decimal overdraftLimit)
            : base(accountNumber, owner, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        // снятие с учетом овердрафта
        public override void Withdraw(decimal amount)
        {
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount}. Баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Превышен лимит овердрафта!");
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Лимит овердрафта: {OverdraftLimit}");
        }
    }
}
