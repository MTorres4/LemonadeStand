using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {
        //member variables
        public Store()
        {
            //constructor
        }
        public void StoreFront(Player player)
        {
            Console.WriteLine("Welcome to the 'Lemonade 4u Products and Stuff' store!"
                + $" \n your current wallet balance is: {player.wallet.balance}."
                + $" \n your current inventory is: {player.inventory.cups.Count}, {player.inventory.lemons.Count}, {player.inventory.sugar.Count}, {player.inventory.ice.Count}."
                + " \n type in which product you need: 'cups', 'lemons', 'sugar', or 'ice';"
                + " \n or type in 'leave' to leave the store to go start your day of lemonade sales!"
                + " \n Please type in one of the items to be able to restart to quit the game.");
            string StoreMenuChoice = Console.ReadLine().ToLower().Trim();

            switch (StoreMenuChoice)
            {
                case "cups":
                    SellCups(new Cups(), new Player());
                    break;
                case "lemons":
                    SellLemons(new Lemons(), new Player());
                    break;
                case "sugar":
                    SellSugar(new Sugar(), new Player());
                    break;
                case "ice":
                    SellIce(new Ice(), new Player());
                    break;
                case "leave":
                    //send to recipe and price
                    break;
                default:
                    Console.WriteLine("Please select one of the options.");
                    StoreFront(new Player());
                    break;
            }
        }
        private void SellCups(Cups cups, Player player)
        {
            Console.WriteLine("Need cups? No problem!"
                + $" \n type 'yes' to purchase 50 cups for {cups.cost}; "
                + " \n type 'no' to return to the store menu;"
                + " \n type 'restart' to restart the game;"
                + " \n or type 'quit' to exit the game."); 
            string CupDecision = Console.ReadLine().ToLower().Trim();

            switch (CupDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(cups.cost);
                    player.inventory.cups.Add(50);
                    break;
                case "no":
                    StoreFront(new Player());
                    break;
                case "restart":
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellCups(cups, player);
                        break;
            }
        }
        private void SellLemons(Lemons lemons, Player player)
        {
            Console.WriteLine("Need lemons? No problem!"
                + $" \n type 'yes' to purchase 30 lemons for {lemons.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'restart' to restart the game;"
                + " \n or type 'quit' to exit the game.");
            string LemonDecision = Console.ReadLine().ToLower().Trim();

            switch (LemonDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(lemons.cost);
                    player.inventory.lemons.Add(30);
                    break;
                case "no":
                    StoreFront(new Player());
                    break;
                case "restart":
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellLemons(lemons, player);
                    break;
            }
        }
        private void SellSugar(Sugar sugar, Player player)
        {
            Console.WriteLine("Need sugar? No problem!"
                + $" \n type 'yes' to purchase 25 cups of sugar for {sugar.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'restart' to restart the game;"
                + " \n type 'quit' to exit the game.");
            string SugarDecision = Console.ReadLine().ToLower().Trim();

            switch (SugarDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(sugar.cost);
                    player.inventory.sugar.Add(25);
                    break;
                case "no":
                    StoreFront(new Player());
                    break;
                case "restart":
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellSugar(sugar, player);
                    break;
            }
        }
        private void SellIce(Ice ice, Player player)
        {
            Console.WriteLine($"Need ice? No problem!"
                + $" \n type 'yes' to purchase 250 pounds of ice for {ice.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'restart' to restart game;"
                + " \n type 'quit' to exit the game.");
            string IceDecision = Console.ReadLine().ToLower().Trim();

            switch (IceDecision)
            {
                case "yes":
                    player.wallet.SubtractFromBalance(ice.cost);
                    player.inventory.ice.Add(250);
                    break;
                case "no":
                    StoreFront(new Player());
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellIce(ice, player);
                    break;
            }
        }
    }
}
