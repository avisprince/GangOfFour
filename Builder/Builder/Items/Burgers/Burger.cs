using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Packing;

namespace Builder.Items
{
    public abstract class Burger : IFoodItem
    {
        public abstract string Name { get; }

        public abstract double Price { get; }

        public IPacking Packing
        {
            get
            {
                return new Wrapper();
            }
        }
    }
}
