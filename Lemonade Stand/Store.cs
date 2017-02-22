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
        public void StoreFront()
        {
            Console.WriteLine("Welcome to the 'Lemonade 4u Products and Stuff' store!"
                + $" \n your current wallet balance is:"
                + $" \n your current inventory is:"
                + " \n type in which product you need: 'cups', 'lemons', 'sugar', or 'ice';"
                + " \n or type in 'leave' to leave the store to go start your day of lemonade sales!"
                + " \n Please type in one of the items to be able to restart to quit the game.");
            string StoreMenuChoice = Console.ReadLine().ToLower().Trim();

            switch (StoreMenuChoice)
            {
                case "cups":
                    SellCups(new Cups(), new Wallet());
                    break;
                case "lemons":
                    SellLemons(new Lemons(), new Wallet());
                    break;
                case "sugar":
                    SellSugar(new Sugar(), new Wallet());
                    break;
                case "ice":
                    SellIce(new Ice(), new Wallet());
                    break;
                case "leave":
                    //send to recipe and price
                    break;
                default:
                    Console.WriteLine("Please select one of the options.");
                    StoreFront();
                    break;
            }
        }
        private void SellCups(Cups cups, Wallet wallet)
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
                    wallet.SubtractFromBalance(cups.cost);
                    break;
                case "no":
                    StoreFront();
                    break;
                case "restart":
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellCups(cups, wallet);
                        break;
            }
        }
        private void SellLemons(Lemons lemons, Wallet wallet)
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
                    wallet.SubtractFromBalance(lemons.cost);
                    break;
                case "no":
                    StoreFront();
                    break;
                case "restart":
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellLemons(lemons, wallet);
                    break;
            }
        }
        private void SellSugar(Sugar sugar, Wallet wallet)
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
                    wallet.SubtractFromBalance(sugar.cost);
                    break;
                case "no":
                    StoreFront();
                    break;
                case "restart":
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellSugar(sugar, wallet);
                    break;
            }
        }
        private void SellIce(Ice ice, Wallet wallet)
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
                    wallet.SubtractFromBalance(ice.cost);
                    break;
                case "no":
                    StoreFront();
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    SellIce(ice, wallet);
                    break;
            }
        }
    }
}
