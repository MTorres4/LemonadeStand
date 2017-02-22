using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Daily_Plan
    {
        Recipe recipe;
        double price;

        public Daily_Plan()
        {
            recipe = new Recipe();
            price = 0.25;
        }
        public virtual void CreateRecipe()
        {

        }
        public virtual void SetPrice()
        {

        }
    }
}
