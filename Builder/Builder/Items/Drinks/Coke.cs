using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Items.Drinks
{
    public class Coke : Drink
    {
        public override string Name
        {
            get
            {
                return "Coke";
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
