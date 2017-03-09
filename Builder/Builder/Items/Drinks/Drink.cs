using Builder.Packing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Items
{
    public abstract class Drink : IFoodItem
    {
        public abstract string Name { get; }

        public abstract double Price { get; }

        public IPacking Packing
        {
            get
            {
                return new Bottle();
            }
        }
    }
}
