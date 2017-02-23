using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {

        public Customer(int customer)
        {
            //CustomersToBuy();
        }

        private void CustomersToBuy(Recipe recipe, Weather weather, Wallet wallet)
        {
            if(recipe.price == 0.00 - 0.20 && weather.actual == 50 - 60)
            {
                wallet.AddToBalance(recipe.price);
            }
            else if(recipe.price == 0.00 - 0.30 && weather.actual == 61 - 70)
            {
                wallet.AddToBalance(recipe.price);
            }
            else if(recipe.price == 0.00 - 0.40 && weather.actual == 71 - 90)
            {
                wallet.AddToBalance(recipe.price);
            }
            else if(recipe.price == 0.00 - 0.50 && weather.actual == 91 - 100)
            {
                wallet.AddToBalance(recipe.price);
            }
        }
        public void SellLemonade()
        {

        }
    }
}
