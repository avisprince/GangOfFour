using Factory.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shape)
        {
            switch(shape)
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
