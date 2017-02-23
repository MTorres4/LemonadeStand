using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public Player player;
        public Store store;
        public Day day;

        public Game()
        {
            player = new Player();
        }
        private void method()
        {

        }
        public void PlayGame()
        {
            store = new Store();
            store.StoreFront(player);
            day = new Day();
            day.weather.DayWeather();
            day.weather.WeekWeather();
        }
    }
}
