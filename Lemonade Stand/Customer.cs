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
        public Customer()
        {
           
        }

        private void CustomersToBuy(Day day, Player player)
        {
            if(day.recipe.price < 0.19 && day.weather.actual < 55)
            {
                day.pitcher.PourPitcher(player, day);
                player.wallet.AddToBalance(day.recipe.price);
            }
            else if(day.recipe.price < 0.20 && day.weather.actual > 56 && day.weather.actual < 60)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    player.wallet.AddToBalance(day.recipe.price);
                }
                else
                {

                }
            }
            else if(day.recipe.price < 0.30 && day.weather.actual > 61 && day.weather.actual < 70)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    player.wallet.AddToBalance(day.recipe.price);
                }
                else
                {

                }
            }
            else if(day.recipe.price < 0.40 && day.weather.actual > 71 && day.weather.actual < 90)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    player.wallet.AddToBalance(day.recipe.price);
                }
                else
                {

                }
            }
            else if(day.recipe.price < 0.50 && day.weather.actual > 91 && day.weather.actual < 100)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    player.wallet.AddToBalance(day.recipe.price);
                }
                else
                {

                }
            }
            else
            {

            }
        }
        public void BuyingLemonade(Day day, Player player)
        {
            CustomersToBuy(day, player);
        }
    }
}
