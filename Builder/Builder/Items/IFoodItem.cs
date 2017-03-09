using Builder.Packing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Items
{
    public interface IFoodItem
    {
        string Name { get; }

        double Price { get; }

        IPacking Packing { get; }
    }
}
