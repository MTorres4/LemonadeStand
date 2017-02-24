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
            store = new Store();
            day = new Day();
            day.weather.DayWeather();
            store.StoreFront(player, day);
            day.NewDay(player, day);
        }
    }
}
