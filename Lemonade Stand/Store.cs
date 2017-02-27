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
        public void StoreFront(Player player, Day day)
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
                            + " \n Please type in one of the items to quit the game.");
            string StoreMenuChoice = Console.ReadLine().ToLower().Trim();

            switch (StoreMenuChoice)
            {
                case "cups":
                    SellCups(new Cups(), player, day);
                    break;
                case "lemons":
                    SellLemons(new Lemons(), player, day);
                    break;
                case "sugar":
                    SellSugar(new Sugar(), player, day);
                    break;
                case "ice":
                    SellIce(new Ice(), player, day);
                    break;
                case "leave":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select one of the options.");
                    StoreFront(player, day);
                    break;
            }
        }
        private void SellCups(Cups cups, Player player, Day day)
        {
            Console.WriteLine("Need cups? No problem!"
                + $" \n type 'yes' to purchase 50 cups for ${cups.cost}; "
                + " \n type 'no' to return to the store menu;"
                + " \n or type 'quit' to exit the game."); 
            string CupDecision = Console.ReadLine().ToLower().Trim();

            switch (CupDecision)
            {
                case "yes":
                    bool enoughmoney = player.wallet.ConfirmWalletBalance(cups.cost);
                    {
                        if (enoughmoney == true)
                        {
                            player.wallet.SubtractFromBalance(cups.cost);
                            player.inventory.AddToCups();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to purchase this item..."
                                + " \n You will need to use up your current inventory or restart the game after this round."
                                + " \n Press enter to return back to the store.");
                            Console.ReadLine();
                        }
                    }
                    Console.Clear();
                    StoreFront(player, day);
                    break;
                case "no":
                    StoreFront(player, day);
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellCups(cups, player, day);
                        break;
            }
        }
        private void SellLemons(Lemons lemons, Player player, Day day)
        {
            Console.WriteLine("Need lemons? No problem!"
                + $" \n type 'yes' to purchase 30 lemons for ${lemons.cost};"
                + " \n type 'no' to return to the store;"
                + " \n or type 'quit' to exit the game.");
            string LemonDecision = Console.ReadLine().ToLower().Trim();

            switch (LemonDecision)
            {
                case "yes":
                    bool enoughmoney = player.wallet.ConfirmWalletBalance(lemons.cost);
                    {
                        if (enoughmoney == true)
                        {
                            player.wallet.SubtractFromBalance(lemons.cost);
                            player.inventory.AddToLemons();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to purchase this item..."
                                + " \n You will need to use up your current inventory or restart the game after this round."
                                + " \n Press enter to return back to the store.");
                            Console.ReadLine();
                        }
                    }
                    Console.Clear();
                    StoreFront(player, day);
                    break;
                case "no":
                    StoreFront(player, day);
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellLemons(lemons, player, day);
                    break;
            }
        }
        private void SellSugar(Sugar sugar, Player player, Day day)
        {
            Console.WriteLine("Need sugar? No problem!"
                + $" \n type 'yes' to purchase 25 cups of sugar for ${sugar.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'quit' to exit the game.");
            string SugarDecision = Console.ReadLine().ToLower().Trim();

            switch (SugarDecision)
            {
                case "yes":
                    bool enoughmoney = player.wallet.ConfirmWalletBalance(sugar.cost);
                    {
                        if (enoughmoney == true)
                        {
                            player.wallet.SubtractFromBalance(sugar.cost);
                            player.inventory.AddToSugar();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to purchase this item..."
                                + " \n You will need to use up your current inventory or restart the game after this round."
                                + " \n Press enter to return back to the store.");
                            Console.ReadLine();
                        }
                    }
                    Console.Clear();
                    StoreFront(player, day);
                    break;
                case "no":
                    StoreFront(player, day);
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellSugar(sugar, player, day);
                    break;
            }
        }
        private void SellIce(Ice ice, Player player, Day day)
        {
            Console.WriteLine($"Need ice? No problem!"
                + $" \n type 'yes' to purchase 250 pieces of ice for ${ice.cost};"
                + " \n type 'no' to return to the store;"
                + " \n type 'quit' to exit the game.");
            string IceDecision = Console.ReadLine().ToLower().Trim();

            switch (IceDecision)
            {
                case "yes":
                    bool enoughmoney = player.wallet.ConfirmWalletBalance(ice.cost);
                    {
                        if (enoughmoney)
                        {
                            player.wallet.SubtractFromBalance(ice.cost);
                            player.inventory.AddToIce();
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money to purchase this item..."
                                + " \n You will need to use up your current inventory or restart the game after this round."
                                + " \n Press enter to return back to the store.");
                            Console.ReadLine();
                        }
                    }
                    Console.Clear();
                    StoreFront(player, day);
                    break;
                case "no":
                    StoreFront(player, day);
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option.");
                    SellIce(ice, player, day);
                    break;
            }
        }
    }
}
