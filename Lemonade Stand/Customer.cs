using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        int willBuy;
        bool bought;
        Random rnd;
        public Customer(Random prob)
        {
            rnd = prob;
        }

        private bool CustomersToBuy(Player player, Day day)
        {
            if (day.recipe.price <= 0.19 && day.weather.actual <= 55)
            {
                day.pitcher.InventoryValidation(player, day);
                player.wallet.AddToBalance(day.recipe.price);
                bought = true;
                return bought;
            }
            else if (day.recipe.price <= 0.20 && day.weather.actual >= 56 && day.weather.actual <= 60)
            {
                willBuy = rnd.Next(2);

                if (willBuy == 0)
                {
                    day.pitcher.InventoryValidation(player, day);
                    player.wallet.AddToBalance(day.recipe.price);
                    bought = true;
                    return bought;
                }
                else
                {
                    bought = false;
                    return bought;
                }
            }
            else if (day.recipe.price <= 0.30 && day.weather.actual >= 61 && day.weather.actual <= 70)
            {
                willBuy = rnd.Next(2);

                if (willBuy == 0)
                {
                    day.pitcher.InventoryValidation(player, day);
                    player.wallet.AddToBalance(day.recipe.price);
                    bought = true;
                    return bought;
                }
                else
                {
                    bought = false;
                    return bought;
                }
            }
            else if (day.recipe.price <= 0.40 && day.weather.actual >= 71 && day.weather.actual <= 90)
            {
                willBuy = rnd.Next(2);

                if (willBuy == 0)
                {
                    day.pitcher.InventoryValidation(player, day);
                    player.wallet.AddToBalance(day.recipe.price);
                    bought = true;
                    return bought;
                }
                else
                {
                    bought = false;
                    return bought;
                }
            }
            else if (day.recipe.price <= 0.50 && day.weather.actual >= 91 && day.weather.actual <= 100)
            {
                willBuy = rnd.Next(2);

                if (willBuy == 0)
                {
                    day.pitcher.InventoryValidation(player, day);
                    player.wallet.AddToBalance(day.recipe.price);
                    bought = true;
                    return bought;
                }
                else
                {
                    bought = false;
                    return bought;
                }
            }
            else
            {
                bought = false;
                return bought;
            }
        }
        public bool BuyingLemonade(Player player, Day day)
        {
            return CustomersToBuy(player, day);
            
        }

    }
}
