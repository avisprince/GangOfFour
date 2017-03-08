using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class FactoryProducer
    {
        public static Factories.AbstractFactory GetFactory(string factory)
        {
            switch(factory)
            {
                case "Shape":
                    return new ShapeFactory();
                case "Color":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
