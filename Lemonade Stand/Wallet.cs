using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Wallet
    {
        public double balance;

        public Wallet()
        {
            balance = 20.00;
        }
        public void SubtractFromBalance(double AmountToSubtract)
        {
            balance -= AmountToSubtract;
        }

        public bool ConfirmWalletBalance(double amount)
        {
            if(balance - amount> 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddToBalance(double amount)
        {
            balance += amount;
        }
    }
}
