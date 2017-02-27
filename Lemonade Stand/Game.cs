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

        private void ContinueToPlay()
        {
            Console.WriteLine("Would you like to continue to play?"
                + " \n Type 'yes' to continue,"
                + " \n Type 'no' to quit,"
                + " \n or Type 'restart' to start the game over.");
            string ContinueDecision = Console.ReadLine().ToLower().Trim();

            switch (ContinueDecision)
            {
                case "yes":
                    Console.Clear();
                    PlayRound();
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
                case "restart":
                    player = new Player();
                    PlayGame();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option");
                    ContinueToPlay();
                    break;
            }
        }

        private void PlayRound()
        {
            for (int i = 0; player.round < 7; i++)
            {
                PlayGame();
            }
            if(player.round == 7)
            {
                DetermineProfitorLoss(player);
            }
        }

        private void DetermineProfitorLoss(Player player)
        {
            if(player.wallet.balance > 50.00)
            {
                Console.WriteLine("Yay! You made a great profit and have enough to buy the game!");
                EndGame();
            }
            else if(player.wallet.balance > 40.00)
            {
                Console.WriteLine("Great job! You made a profit, but you will need to trade-in Madden to get For Honor...");
                EndGame();
            }
            else if(player.wallet.balance > 30.00)
            {
                Console.WriteLine("Good work! You made a profit, but you will need to sell your holographic Bulbasaur card...");
                EndGame();
            }
            else if(player.wallet.balance >= 20.00)
            {
                Console.WriteLine("Not bad, you made a little more than what you started with... maybe sell some beanie babies and lemonade...");
                EndGame();
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not make a profit... You may need to sell Madden, your holographic Bulbasaur card, and some beanie babies...");
                EndGame();
            }
        }

        private void EndGame()
        {
            Console.WriteLine("             Thank you for playing!"
                + " \n Type 'play again' to restart the game, or 'quit' to exit the game");
            string EndDecision = Console.ReadLine().ToLower().Trim();

            switch (EndDecision)
            {
                case "play again":
                    player = new Player();
                    PlayGame();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a valid option");
                    EndGame();
                    break;
            }

        }

        public void PlayGame()
        {
            store = new Store();
            day = new Day();
            day.weather.DayWeather();
            store.StoreFront(player, day);
            day.NewDay(player, day);
            day.DisplayDailySummary(player);
            player.round++;
            ContinueToPlay();
        }
    }
}
