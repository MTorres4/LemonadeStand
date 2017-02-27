using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player
    {
        public int round;
        public Wallet wallet;
        public Inventory inventory;

        public Player()
        {
            this.round = 0;
            wallet = new Wallet();
            inventory = new Inventory();

        }
    }
}
