using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Model.Color;
using AbstractFactory.Model.Shape;

namespace AbstractFactory.Factories
{
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            switch (color)
            {
                case "Red":
                    return new Red();
                case "Blue":
                    return new Blue();
                default:
                    return null;
            }
        }

        public override IShape GetShape(string shape)
        {
            throw new NotImplementedException();
        }
    }
}
