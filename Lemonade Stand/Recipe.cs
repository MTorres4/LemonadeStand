using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Recipe : Daily_Plan
    {
        public int ingredients;

        public Recipe()
        {

        }
        public override void CreateRecipe()
        {

        }

        public override void SetPrice()
        {
            get
                {
                return price;
            }
            set
                {
                price = value;
            }
        }
    }
}
