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

        private void CustomersToBuy(Recipe recipe, Weather weather, Wallet wallet)
        {
            if(recipe.price < 0.19 && weather.actual < 55)
            {
                    wallet.AddToBalance(recipe.price);
            }
            else if(recipe.price < 0.20 && weather.actual > 56 && weather.actual < 60)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    wallet.AddToBalance(recipe.price);
                }
                else
                {

                }
            }
            else if(recipe.price < 0.30 && weather.actual > 61 && weather.actual < 70)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    wallet.AddToBalance(recipe.price);
                }
                else
                {

                }
            }
            else if(recipe.price < 0.40 && weather.actual > 71 && weather.actual < 90)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    wallet.AddToBalance(recipe.price);
                }
                else
                {

                }
            }
            else if(recipe.price < 0.50 && weather.actual > 91 && weather.actual < 100)
            {
                Random rnd = new Random();
                willBuy = rnd.Next(2);

                if(willBuy == 0)
                {
                    wallet.AddToBalance(recipe.price);
                }
                else
                {

                }
            }
            else
            {

            }
        }
        public void BuyingLemonade(Recipe recipe, Weather weather, Wallet wallet)
        {
            CustomersToBuy(recipe, weather, wallet);
        }
    }
}
