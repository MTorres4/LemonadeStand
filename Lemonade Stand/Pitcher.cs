using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Pitcher
    {
        int full;

        public Pitcher()
        {
            full = 12;
        }
        private int MakePitcher(Player player, Day day)
        {
            for(int i = 0; i < day.recipe.lemons; i++)
            {
            player.inventory.lemons.RemoveAt(0);
            }
            for(int i = 0; i < day.recipe.sugar; i++)
            {
                player.inventory.sugar.RemoveAt(0);
            }
            return full;
        }

        public void PourPitcher(Player player, Day day)
        {
            full -= 1;
            player.inventory.cups.RemoveAt(0);
            for(int i = 0; i < day.recipe.ice; i++)
            {
                player.inventory.ice.RemoveAt(0);
            }
            if(full == 0)
            {
                ConfirmInventory(player, day);
            }
        }

        public void ConfirmInventory(Player player, Day day)
        {
            do
            {
                MakePitcher(player,day);
            }

            while (player.inventory.cups.Count > 0 && player.inventory.lemons.Count > 0 && player.inventory.sugar.Count > 0 && player.inventory.ice.Count > 0);
        }
    }
}