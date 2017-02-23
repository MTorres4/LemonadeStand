using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
        int weather;
        string weatherOptions;
        int outlook;
        int actual;

        //member variables
        public Weather()
        {
            string[] weatherOptions = { "Sunny", "Overcast", "Rainy" };
            outlook = 0;
            actual = 0;
            //constructor
        }
        private void SetWeather()
        {
            Random rnd = new Random();
            weather = rnd.Next(4);
        }

        private void SetOutlookTemp()
        {
            Random rnd = new Random();
            outlook = rnd.Next(50-100);
        }

        private void SetActualTemp()
        {
            Random rnd = new Random();
            actual = rnd.Next(50 - 100);
        }
    }
}
