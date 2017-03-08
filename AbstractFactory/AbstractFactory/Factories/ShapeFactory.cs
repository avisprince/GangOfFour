using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Model.Color;
using AbstractFactory.Model.Shape;

namespace AbstractFactory.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            throw new NotImplementedException();
        }

        public override IShape GetShape(string shape)
        {
            switch (shape)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                case "Triangle":
                    return new Triangle();
                default:
                    return null;
            }
        }
    }
}
