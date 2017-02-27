using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {

        public Store()
        {

        }
        public void StoreFront(Player player, Day day, Game game)
        {
            Console.WriteLine("     Welcome to the 'Lemonade 4u Products and Stuff' store!     "
                            + " \n"
                            + $" \n The TV at the store shows the 7 day forecast as: "
                            + " \n Day 1 Sunny! 64, Day 2 Overcast 76, Day 3 Sunny! 88, Day 4 Rainy 57,"
                            + " \n Day 5 Overcast 55, Day 6 Sunny! 83, Day 7 Rainy 73; I hope it stays that way!"
                            + $" \n The sign at the store shows- weather/temperature today is: {day.weather.outside}, {day.weather.actual}."
                            + $" \n Your current wallet balance is: ${player.wallet.balance}."
                + $" \n Your current inventory is: cups: {player.inventory.cups.Count}, lemons: {player.inventory.lemons.Count}, sugar: {player.inventory.sugar.Count}, ice: {player.inventory.ice.Count}."
                            + " \n Type in which product you need: 'cups', 'lemons', 'sugar', or 'ice';"
                            + " \n or type in 'leave' to leave the store to go start your day of lemonade sales!"
                            + " \n Please type in one of the items to be able to restart to quit the game.");
            string StoreMenuChoice = Console.ReadLine().ToLower().Trim();

            switch (StoreMenuChoice)
            {
                case "cups":
                    SellCups(new Cups(), player, day, game);
                    break;
                case "lemons":
                    SellLemons(new Lemons(), player, day, game);
                    break;
                case "sugar":
                    SellSugar(new Sugar(), player, day, game);
                    break;
                case "ice":
                    SellIce(new Ice(), player, day, game);
                    break;
                case "leave":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select one of the options.");
                    StoreFront(player, day, game);
                    break;
            }
        }
        private void SellCups(Cups cups, Player player, Day day, Game game)
        {
            Console.WriteLine("Need cups? No problem!"
                + $" \n type 'yes' to purchase 50 cups for ${cups.cost}; "
                + " \n type 'no' to return to the store menu;"
                + " \n type 'restart' to restart the game;"
                + " \n or type 'quit' to exit the game."); 
            string CupDecision = Console.ReadLine().ToLower().Trim();

            switch (CupDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(cups.cost);
                    player.inventory.AddToCups();
                    Console.Clear();
                    StoreFront(player, day, game);
                    break;
                case "no":
                    StoreFront(player, day, game);
                    break;
                case "restart":
                    player = new Player();
                    game.PlayGame();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellCups(cups, player, day, game);
                        break;
            }
        }
        private void SellLemons(Lemons lemons, Player player, Day day, Game game)
        {
            Console.WriteLine("Need lemons? No problem!"
                + $" \n type 'yes' to purchase 30 lemons for ${lemons.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'restart' to restart the game;"
                + " \n or type 'quit' to exit the game.");
            string LemonDecision = Console.ReadLine().ToLower().Trim();

            switch (LemonDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(lemons.cost);
                    player.inventory.AddToLemons();
                    Console.Clear();
                    StoreFront(player, day, game);
                    break;
                case "no":
                    StoreFront(player, day, game);
                    break;
                case "restart":
                    player = new Player();
                    game.PlayGame();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellLemons(lemons, player, day, game);
                    break;
            }
        }
        private void SellSugar(Sugar sugar, Player player, Day day, Game game)
        {
            Console.WriteLine("Need sugar? No problem!"
                + $" \n type 'yes' to purchase 25 cups of sugar for ${sugar.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'restart' to restart the game;"
                + " \n type 'quit' to exit the game.");
            string SugarDecision = Console.ReadLine().ToLower().Trim();

            switch (SugarDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(sugar.cost);
                    player.inventory.AddToSugar();
                    Console.Clear();
                    StoreFront(player, day, game);
                    break;
                case "no":
                    StoreFront(player, day, game);
                    break;
                case "restart":
                    player = new Player();
                    game.PlayGame();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellSugar(sugar, player, day, game);
                    break;
            }
        }
        private void SellIce(Ice ice, Player player, Day day, Game game)
        {
            Console.WriteLine($"Need ice? No problem!"
                + $" \n type 'yes' to purchase 250 pieces of ice for ${ice.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'restart' to restart game;"
                + " \n type 'quit' to exit the game.");
            string IceDecision = Console.ReadLine().ToLower().Trim();

            switch (IceDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(ice.cost);
                    player.inventory.AddToIce();
                    Console.Clear();
                    StoreFront(player, day, game);
                    break;
                case "no":
                    StoreFront(player, day, game);
                    break;
                case "restart":
                    player = new Player();
                    game.PlayGame();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellIce(ice, player, day, game);
                    break;
            }
        }
    }
}
