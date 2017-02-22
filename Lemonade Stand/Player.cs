using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player
    {

        public Wallet wallet;
        public Inventory inventory;
        //member variables

        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();

            //constructor
        }
    }
}
