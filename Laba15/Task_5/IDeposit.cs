using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public interface IDepositWithdraw
    {
        void Deposit(decimal amount);   // внести
        void Withdraw(decimal amount);  // снять
    }
}
