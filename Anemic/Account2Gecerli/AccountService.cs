using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anemic.Account2Gecerli
{
    public class AccountService
    {
        private static readonly double EFT_CHARGE = 3;
        //private AmountValidator validator = new AmountValidator();

        public void Withdraw(Account account, double amount)
        {
            //validate
            account.Withdraw(amount);
        }

        public void Deposit(Account account, double amount)
        {
            //validate
            account.deposit(amount);
        }

        public void Eft(Account sourceAccount, Account targetAccount, double amount)
        {
            //validate
            sourceAccount.Withdraw(amount);
            sourceAccount.Withdraw(EFT_CHARGE);
            targetAccount.deposit(amount);
        }
    }
}
