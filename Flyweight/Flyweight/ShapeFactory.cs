using Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> circleDictionary = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            var circle = (Circle)circleDictionary[color];

            if (circle == null)
            {
                circle = new Circle { Color = color };
                circleDictionary.Add(color, circle);

                Console.WriteLine("Creating circle of color : " + color);
            }

            return circle;
        }
    }
}
