using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = FactoryProducer.GetFactory("Shape");
            var colorFactory = FactoryProducer.GetFactory("Color");

            var circle = shapeFactory.GetShape("Circle");
            circle.Draw();

            var red = colorFactory.GetColor("Red");
            red.Fill();
        }
    }
}
