using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class BankAccount
    {
        private string Owner;
        private double Balance;

        public BankAccount(string accountOwner, double accountBalance)
        {
            Owner = accountOwner;

            if (accountBalance >= 0)
            {
                Balance = accountBalance;
            }
            else
            {
                Balance = 0;
                Console.WriteLine("Баланс не может быть отрицательным!");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма должна быть больше 0!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств!");
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма должна быть больше 0!");
            }
        }
    }
}
