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
        double dailysales;
        double overallsales;

        public Day()
        {
            weather = new Weather();
            recipe = new Recipe();
            pitcher = new Pitcher();
            customers = new List<Customer>();
            dailysales = 0;
            overallsales = 0;
        }
        private void GenerateCustomers()
        {
            for (int i=0; i < 90; i++)
            {
                customers.Add(new Customer());
            }
        }

        public void NewDay(Player player, Day day)
        {
            //weather.WeekWeather();
            //weather.DayWeather();
            recipe.SetRecipe(player);
            pitcher.MakePitcher(player, day);
            GenerateCustomers();
            foreach (Customer customer in customers)
            {
                customer.BuyingLemonade(player, day);
            }
        }
    }
}
