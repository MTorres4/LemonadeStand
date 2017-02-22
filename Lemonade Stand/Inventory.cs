using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory : Player
    {
        //public int available;
        public List<int> cups;
        public List<int> lemons;
        public List<int> sugar;
        public List<int> ice;

        public Inventory()
        {
        cups = new List<int>();
        lemons = new List<int>();
        sugar = new List<int>();
        ice = new List<int>();

        }
       // public void SubtractFromAvailable(int AmountToSubtract)
        //{
          //  if(available - AmountToSubtract >= 0)
            //{
              //  available -= AmountToSubtract;
            //}
            //Console.WriteLine("None left!");
        //}
        //public void AddToAvailable(int amount)
        //{
          //  available += amount;
        //}
    }
}
