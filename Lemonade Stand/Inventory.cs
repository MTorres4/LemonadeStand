using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {
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

        public void AddToCups()
        {
            for (int i = 0; i < 50; i++)
            {
                cups.Add(50);
            }
        }
        public void AddToLemons()
        {
            for(int i = 0; i < 30; i++)
            {
                lemons.Add(30);
            }
        }
        public void AddToSugar()
        {
            for(int i = 0; i < 25; i++)
            {
                sugar.Add(25);
            }
        }
        public void AddToIce()
        {
            for(int i = 0; i < 250; i++)
            {
                ice.Add(250);
            }
        }
    }
}
