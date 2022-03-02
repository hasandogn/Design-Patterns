using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anemic.Account2Gecerli
{
    public class Account
    {
        public string Iban { get; set; }
        public double Balance { get; set; }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
                throw new Exception("Error");
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }
    }
}
