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

        public bool ConfirmWalletBalance()
        {
            if(balance > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase this item,"
                    + " \n you will need to start over or use up what you have");
                return false;
            }
        }

        public void AddToBalance(double amount)
        {
            balance += amount;
        }
    }
}
