using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class BankAccount : IDepositWithdraw, ITransfer
    {
        public string Owner { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }

        // Внесение
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Owner}: сумма должна быть больше нуля");
                return;
            }

            Balance += amount;
            Console.WriteLine($"{Owner} внес {amount} руб, баланс: {Balance}");
        }

        // Снятие
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Owner}: сумма должна быть больше нуля");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{Owner} снял {amount} руб. Остаток: {Balance}");
            }
            else
            {
                Console.WriteLine($"{Owner}: недостаточно средств, Баланс: {Balance}");
            }
        }

        // Переводы
        public void Transfer(BankAccount target, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Owner}: сумма перевода должна быть больше нуля");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                target.Balance += amount;
                Console.WriteLine($"{Owner} перевёл {amount} руб, на счёт {target.Owner}");
            }
            else
            {
                Console.WriteLine($"{Owner}: не хватает денег для перевода");
            }
        }

        // Метод для вывода информации о счёте
        public void ShowInfo()
        {
            Console.WriteLine($"Счёт {Owner}: {Balance} руб");
        }
    }
}
