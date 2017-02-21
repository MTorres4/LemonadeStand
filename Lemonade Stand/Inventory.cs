using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {
        //member variables
        public int quantity;
        
        public Inventory()
        {
            this.quantity = 0;
            //constructor
        }
        public virtual void GetQuantities()
        {

        }
    }
}
