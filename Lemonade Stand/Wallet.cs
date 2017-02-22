using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Wallet : Player
    {
        public double balance;

        public Wallet()
        {
            balance = 20.00;
            //TODO, if this reaches 0, send to end game
        }
        public void SubtractFromBalance(double AmountToSubtract)
        {
            if(balance - AmountToSubtract >= 0)
            {
                balance -= AmountToSubtract;
            }
            Console.WriteLine("You don't have enough money to purchase this item,"
                + " \n you will need to use up your current inventory, or"
                + " \n you can start the game over");
        }
        public void AddToBalance(double amount)
        {
            balance += amount;
        }
    }
}
