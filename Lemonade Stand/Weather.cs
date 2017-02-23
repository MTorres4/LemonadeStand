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
        int outlook;
        public int actual;

        public Weather()
        {
            weather = 0;
            outlook = 0;
            actual = 0;
        }
        private void SetWeather()
        {
            Random rnd = new Random();
            weather = rnd.Next(4);
        }

        private void DisplayWeather(int weather)
        {
            if(weather == 0)
            {
                Console.WriteLine("Sunny!");
                Console.ReadLine();
            }
            else if(weather == 1)
            {
                Console.WriteLine("Overcast");
                Console.ReadLine();
            }
            else if(weather == 2)
            {
                Console.WriteLine("Rainy");
                Console.ReadLine();
            }
        }
        private void SetOutlookTemp()
        {
            Random rnd = new Random();
            outlook = rnd.Next(50, 100);
        }

        private void DisplayOutlookTemp(int outlook)
        {
            Console.WriteLine($"{outlook}");
            Console.ReadLine();
        }

        private void SetActualTemp()
        {
            Random rnd = new Random();
            actual = rnd.Next(50, 100);
        }

        private void DisplayActualTemp(int actual)
        {
            Console.WriteLine($"{actual}");
            Console.ReadLine();
        }
        public void DayWeather()
        {
            SetWeather();
            DisplayWeather(weather);
            SetActualTemp();
            DisplayActualTemp(actual);
        }

        public void WeekWeather()
        {
            SetWeather();
            DisplayWeather(weather);
            SetOutlookTemp();
            DisplayOutlookTemp(outlook);
        }
    }
}
