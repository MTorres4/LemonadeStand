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
            full = 10;
        }
        public void MakePitcher(Player player, Day day)
        {
            for(int i = 0; i < day.recipe.lemons; i++)
            {
            player.inventory.lemons.RemoveAt(0);
            }
            for(int i = 0; i < day.recipe.sugar; i++)
            {
                player.inventory.sugar.RemoveAt(0);
            }
            full = 10;
        }

        public void PourPitcher(Player player, Day day)
        {
            if (full == 0)
            {
                day.ConfirmInventoryNewPitcher(player, day);
            }
            else
            {
                full -= 1;
                player.inventory.cups.RemoveAt(0);

                for (int i = 0; i < day.recipe.ice; i++)
                {
                    player.inventory.ice.RemoveAt(0);
                }
            }
        }
    }
}