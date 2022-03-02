using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anemic.Account1
{
    public class AccountService
    {
        public static readonly double EFT_CHARGE = 3;

        public void Withdraw(Account account, double amount)
        {
            double balance = account.Balance;
            if (balance >= amount)
            {
                balance -= amount;
                account.Balance = balance;
            }
            else
                throw new Exception("Error");
        }

        public void Deposit(Account account, double amount)
        {
            double balance = account.Balance;
            balance += amount;
            account.Balance = balance;
        }

        public void Eft(Account sourceAccount, Account targetAccount, double amount)
        {
            Withdraw(sourceAccount, amount);
            Withdraw(sourceAccount, EFT_CHARGE);
            Deposit(targetAccount, amount);
        }
    }
}
