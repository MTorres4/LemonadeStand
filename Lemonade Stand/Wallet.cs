using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Wallet
    {
        private double amount;
        private Wallet()
        {
            amount = 20.00;
            //TODO, if this reaches 0, send to end game
        }
    }
}
