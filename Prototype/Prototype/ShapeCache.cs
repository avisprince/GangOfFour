using Prototype.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeDictionary = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            var cachedShape = shapeDictionary[shapeId];
            return (Shape)cachedShape.Clone();
        }

        public static void InitCache()
        {
            if (shapeDictionary.Any())
            {
                shapeDictionary = new Dictionary<string, Shape>();
            }

            var circle = new Circle { Id = "1" };
            var square = new Square { Id = "2" };
            var rectangle = new Rectangle { Id = "3" };

            shapeDictionary.Add(circle.Id, circle);
            shapeDictionary.Add(square.Id, square);
            shapeDictionary.Add(rectangle.Id, rectangle);
        }
    }
}
