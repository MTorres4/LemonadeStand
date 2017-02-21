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
        private void CupQuantities()
        {
            Console.WriteLine($"Cups: '25', '50', '100'"); //add {.cost} for each quantity
            int GetCups = int.Parse(Console.ReadLine());

            switch (GetCups)
            {
                case 25:
                    break;
                case 50:
                    break;
                case 100:
                    break;
                default:
                    Console.WriteLine("Please select one of the quantities.");
                    CupQuantities();
                        break;
            }
        }
        private void LemonQuantities()
        {
            Console.WriteLine($"Lemons: '15', '30', '80'"); //add {.cost} for each quantity
            int GetLemons = int.Parse(Console.ReadLine());

            switch (GetLemons)
            {
                case 15:
                    break;
                case 30:
                    break;
                case 80:
                    break;
                default:
                    Console.WriteLine("Please select one of the quantities.");
                    LemonQuantities();
                    break;
            }
        }
        private void SugarQuantities()
        {
            Console.WriteLine($"Sugar: '8', '25', '48'"); //add {.cost} for each quantity
            int GetSugar = int.Parse(Console.ReadLine());

            switch (GetSugar)
            {
                case 8:
                    break;
                case 25:
                    break;
                case 48:
                    break;
                default:
                    Console.WriteLine("Please select one of the quantities.");
                    SugarQuantities();
                    break;
            }
        }
        private void IceQuantities()
        {
            Console.WriteLine($"Ice: '100', '250', '500'"); //add {.cost} for each quantity
            int GetIce = int.Parse(Console.ReadLine());

            switch (GetIce)
            {
                case 100:
                    break;
                case 250:
                    break;
                case 500:
                    break;
                default:
                    Console.WriteLine("Please select one of the quantities.");
                    IceQuantities();
                    break;
            }
        }
    }
}
