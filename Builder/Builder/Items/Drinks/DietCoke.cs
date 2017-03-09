using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Items.Drinks
{
    public class DietCoke : Drink
    {
        public override string Name
        {
            get
            {
                return "Diet Coke";
            }
        }

        public override double Price
        {
            get
            {
                return 1.99;
            }
        }
    }
}
