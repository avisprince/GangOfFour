using AbstractFactory.Model.Color;
using AbstractFactory.Model.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string color);

        public abstract IShape GetShape(string shape);
    }
}
