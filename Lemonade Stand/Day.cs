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
        double dailysales;
        double overallsales;

        public Day()
        {
            weather = new Weather();
            recipe = new Recipe();
            customers = new List<Customer>();
            dailysales = 0;
            overallsales = 0;
        }
        private void GenerateCustomers()
        {
            Random rnd = new Random();
            for (int i=0; i < 90; i++)
            {
                customers.Add(new Customer(rnd.Next(0,90)));
            }
        }

        public void NewDay()
        {
            GenerateCustomers();
        }
        //MakeRound
        //TODO need weather per one day
    }
}
