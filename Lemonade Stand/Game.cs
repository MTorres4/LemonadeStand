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
        public void PlayGame()
        {

            day = new Day();
            day.NewDay(player);
            store = new Store();
            day.weather.DayWeather();
            store.StoreFront(player, day);
        }
    }
}
