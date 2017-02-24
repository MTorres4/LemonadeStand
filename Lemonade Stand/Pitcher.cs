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
            full = 12;
        }

        public void PourPitcher(Player player, Day day)
        {
            if (full == 0)
            {
                ConfirmInventory(player, day);
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

        private void ConfirmInventory(Player player, Day day)
        {
            if (player.inventory.cups.Count > 0 && player.inventory.lemons.Count > 0 && player.inventory.sugar.Count > 0 && player.inventory.ice.Count > 0)
            {
                MakePitcher(player, day);
                PourPitcher(player, day);
            }
            else
            {
                Console.WriteLine("You sold out!"
                    + $" \n Your current inventory is: cups- {player.inventory.cups.Count}, lemons- {player.inventory.lemons.Count}, sugar- {player.inventory.sugar.Count}, ice- {player.inventory.ice.Count}.");
            }
        }
        private void InventoryValidation(Player player, Day day)
        {
            if(player.inventory.cups.Count == 0 || player.inventory.lemons.Count == 0 || player.inventory.sugar.Count == 0 || player.inventory.ice.Count == 0)
            {
                Console.WriteLine("You sold out!"
                + $" \n Your current inventory is: cups- {player.inventory.cups.Count}, lemons- {player.inventory.lemons.Count}, sugar- {player.inventory.sugar.Count}, ice- {player.inventory.ice.Count}.");
                day.DisplayDailySummary(player);
            }
        }
    }
}