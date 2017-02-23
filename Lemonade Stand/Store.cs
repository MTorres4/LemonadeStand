﻿using System;
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
        public void StoreFront(Player player)
        {
            Console.WriteLine("Welcome to the 'Lemonade 4u Products and Stuff' store!"
                + $" \n Your current wallet balance is: ${player.wallet.balance}."
                + $" \n Your current inventory is: cups: {player.inventory.cups.Count}, lemons: {player.inventory.lemons.Count}, sugar: {player.inventory.sugar.Count}, ice: {player.inventory.ice.Count}."
                + " \n Type in which product you need: 'cups', 'lemons', 'sugar', or 'ice';"
                + " \n or type in 'leave' to leave the store to go start your day of lemonade sales!"
                + " \n Please type in one of the items to be able to restart to quit the game.");
            string StoreMenuChoice = Console.ReadLine().ToLower().Trim();

            switch (StoreMenuChoice)
            {
                case "cups":
                    SellCups(new Cups(), player);
                    break;
                case "lemons":
                    SellLemons(new Lemons(), player);
                    break;
                case "sugar":
                    SellSugar(new Sugar(), player);
                    break;
                case "ice":
                    SellIce(new Ice(), player);
                    break;
                case "leave":
                    return;
                default:
                    Console.WriteLine("Please select one of the options.");
                    StoreFront(player);
                    break;
            }
        }
        private void SellCups(Cups cups, Player player)
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
                    StoreFront(player);
                    break;
                case "no":
                    StoreFront(player);
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
                    StoreFront(player);
                    break;
                case "no":
                    StoreFront(player);
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
                    StoreFront(player);
                    break;
                case "no":
                    StoreFront(player);
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
                    StoreFront(player);
                    break;
                case "no":
                    StoreFront(player);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellIce(ice, player);
                    break;
            }
        }
    }
}
