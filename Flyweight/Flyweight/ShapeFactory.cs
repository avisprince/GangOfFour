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
            if (!circleDictionary.ContainsKey(color))
            {
                circleDictionary.Add(color, new Circle { Color = color });

                Console.WriteLine("Creating circle of color : " + color);
            }

            return (Circle)circleDictionary[color];
        }
    }
}
