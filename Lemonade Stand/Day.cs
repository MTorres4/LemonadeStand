using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {
        public Weather weather;
        public Recipe recipe;
        public List<Customer> customers;
        public Pitcher pitcher;
        public int addBuy;
        public double dailySales;

        public Day()
        {
            weather = new Weather();
            recipe = new Recipe();
            pitcher = new Pitcher();
            customers = new List<Customer>();
            addBuy = 0;
            dailySales = 0;
        }
 
        private void GenerateCustomers()
        {
            Random prob = new Random();
            for (int i=0; i < 90; i++)
            {
                customers.Add(new Customer(prob));
            }
        }

        public void NewDay(Player player, Day day)
        {
            recipe.SetRecipe(player);
            pitcher.MakePitcher(player, day);
            GenerateCustomers();
            foreach (Customer customer in customers)
            {
                bool didbuy = customer.BuyingLemonade(player, day);
                if (didbuy)
                {
                    addBuy++;
                }
            }
        }

        private void CalculateDailySales()
        {
            dailySales = addBuy * recipe.price;
        }

        public void DisplayDailySummary(Player player)
        {
            CalculateDailySales();
            Console.WriteLine("Summay of day:"
                + $" \n Total customers-{addBuy}"
                + $" \n Total daily sales-{dailySales}"
                + $" \n Your wallet balance- ${player.wallet.balance}");
        }
    }
}
