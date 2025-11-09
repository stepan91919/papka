using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            BankAccount[] accounts = new BankAccount[2]
            {
            new BankAccount("Иван", 10000m),
            new BankAccount("Анна", 3000m)
            };

            Console.WriteLine("Начальные балансы:");
            foreach (var acc in accounts) acc.ShowInfo();

            Console.WriteLine();

            // перевод с первого счёта на второй
            accounts[0].Transfer(accounts[1], 2500m);

            Console.WriteLine("\nБалансы после перевода:");
            foreach (var acc in accounts) acc.ShowInfo();

            Console.WriteLine();

            // Проверка внесения и снятия денег
            accounts[1].Deposit(1500m);
            accounts[0].Withdraw(2000m);

            Console.WriteLine("\nИтоговые балансы:");
            foreach (var acc in accounts) acc.ShowInfo();
        }
    }
}
