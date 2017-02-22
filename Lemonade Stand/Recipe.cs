using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Recipe
    {
        private double price;
        int lemons;
        int sugar;
        int ice;

        public Recipe()
        {
            price = 0.25;
            lemons = 5;
            sugar = 5;
            ice = 5;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value > 0.99 || value < 0.00)
                {
                    throw new Exception("Number is outside of valid range");
                }
                else
                {
                    price = value;
                }
            }
        }
        public void SetPrice()
        {
            Console.WriteLine("How much would you like to charge for your your lemonade today?"
                + " \n Please enter between 0.01 - 0.99");
            try
            {
                Price = double.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid amount to charge.");
                SetPrice();
            }
        }

        public int Lemons
        {
            get
            {
                return lemons;
            }
            set
            {
                lemons = value;
            }
        }
        public int SetLemons()
        {
            Console.WriteLine("How many lemons would you like to use per pitcher?"
                + " \n Please enter an integer."
                + " \n Remember, if you use up your inventory, you will close for the day.");
            try
            {
                int lemons = int.Parse(Console.ReadLine());
                return lemons;
            }
            catch(FormatException)
            {
                Console.WriteLine("");
                return SetLemons();
            }
        }
        public int Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                sugar = value;
            }
        }
        public int SetSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to use per pitcher?"
                + " \n Please enter an integer");
            try
            {
                int sugar = int.Parse(Console.ReadLine());
                return sugar;
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid amount of sugar to use.");
                return SetSugar();
            }
        }
        public int Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }
        public int SetIce()
        {
            Console.WriteLine("How many ice cubes per cup would you like?"
                + " \n Please enter an integer.");
            try
            {
                int ice = int.Parse(Console.ReadLine());
                return ice;
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid amount of ice cubes.");
                return SetIce();
            }
        }
    }
}
