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
        private void SetPrice()
        {
            Console.WriteLine("How much would you like to charge for your your lemonade today?"
                + " \n Please enter between 0.01 - 0.99");
            try
            {
                Price = double.Parse(Console.ReadLine().Trim());
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
                if (value > 100 || value < 0)
                {
                    throw new Exception("Number is outside of valid range");
                }
                else
                {
                    lemons = value;
                }
            }
        }
        private void SetLemons()
        {
            Console.WriteLine("How many lemons would you like to use per pitcher?"
                + " \n Please enter an integer between 0-100."
                + " \n Remember, if you use up your inventory, you will close for the day.");
            try
            {
                Lemons = int.Parse(Console.ReadLine().Trim());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid amount of lemons to use.");
                SetLemons();
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
                if (value > 100 || value < 0)
                {
                    throw new Exception("Number outside of valid range.");
                }
                else
                {
                    sugar = value;
                }
            }
        }
        private void SetSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to use per pitcher?"
                + " \n Please enter an integer between 0-100."
                + " \n Remember, if you use up your inventory, you will close for the day.");
            try
            {
                Sugar = int.Parse(Console.ReadLine().Trim());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid amount of sugar to use.");
                SetSugar();
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
                if(value > 100 || value < 0)
                {
                    throw new Exception("Number outside of valid range.");
                }
                else
                {
                    ice = value;
                }
            }
        }
        private void SetIce()
        {
            Console.WriteLine("How many ice cubes per cup would you like?"
                + " \n Please enter an integer between 0-100."
                + " \n Remember, if you use up your inventory, you will close for the day.");
            try
            {
                Ice = int.Parse(Console.ReadLine().Trim());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid amount of ice cubes to use per cup.");
                SetIce();
            }
        }
        public void SetRecipe()
        {
            Console.WriteLine("The following prompts will assist in setting the price and recipe for the day:");
            SetPrice();
            SetLemons();
            SetSugar();
            SetIce();
        }
    }
}
