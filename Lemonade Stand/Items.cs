using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Items
    {
        //member variables
        public int quantity;
        public double cost;
        
        public Items()
        {
            this.quantity = 0;
            //constructor
        }
        public virtual void SetQuantities()
        {

        }
        public virtual void SetCost()
        {

        }
    }
}
