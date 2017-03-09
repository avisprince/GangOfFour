using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Items
{
    public class BeefBurger : Burger
    {
        public override string Name
        {
            get
            {
                return "Beef Burger";
            }
        }

        public override double Price
        {
            get
            {
                return 7.00;
            }
        }
    }
}
