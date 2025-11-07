using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // Базовый класс
    public abstract class BankAccount
    {

        public string AccountNumber { get; set; }   // номер счета
        public string Owner { get; set; }           // Владелец счета
        public decimal Balance { get; protected set; } // Баланс

        public BankAccount(string accountNumber, string owner, decimal balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        // пополнение счета
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Пополнение на {amount}. Баланс: {Balance}");
        }

        // снятие средств
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount}. Баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Счет: {AccountNumber}, Владелец: {Owner}, Баланс: {Balance}");
        }
    }
}
