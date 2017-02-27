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
        private void PlayRound()
        {
            while(player.round < 8)
            {
                PlayGame();
            }
        }
        public void PlayGame()
        {
            store = new Store();
            day = new Day();
            day.weather.DayWeather();
            store.StoreFront(player, day);
            day.NewDay(player, day);
            player.round++;
            PlayRound();
        }
    }
}
