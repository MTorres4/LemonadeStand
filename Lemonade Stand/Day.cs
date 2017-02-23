using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {
        public Recipe recipe;
        public Weather weather;
        public Customer customer;
        double dailysales;
        double overallsales;

        public Day()
        {
            recipe = new Recipe();
            weather = new Weather();
            customer = new Customer();
            dailysales = 0;
            overallsales = 0;
        }
        private void method()
        {

        }
        //MakeRound
        //TODO need weather per one day
    }
}
