using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Items
{
    public class VeggieBurger : Burger
    {
        public override string Name
        {
            get
            {
                return "Veggie Burger";
            }
        }

        public override double Price
        {
            get
            {
                return 5.00;
            }
        }
    }
}
