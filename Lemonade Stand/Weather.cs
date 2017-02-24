using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
        public int weather;
        public string outside;
        public int actual;

        public Weather()
        {
            weather = 0;
            actual = 0;
        }
        private void SetWeather()
        {
            Random rnd = new Random();
            weather = rnd.Next(3);
            DisplayWeather(weather);
        }

        private string DisplayWeather(int weather)
        {
            if(weather == 0)
            {
                outside = "Sunny!";
            }
            else if(weather == 1)
            {
                outside = "Overcast";
            }
            else if(weather == 2)
            {
                outside = "Rainy";
            }
            return outside;
        }

        private void SetTemp()
        {
            Random rnd = new Random();
            actual = rnd.Next(50, 100);
        }
        public void DayWeather()
        {
            SetWeather();
            SetTemp();
        }
    }
}
