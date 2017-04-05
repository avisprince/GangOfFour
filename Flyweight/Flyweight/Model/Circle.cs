using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Model
{
    public class Circle : IShape
    {
        public string Color { private get; set; }

        public int X { private get; set; }

        public int Y { private get; set; }

        public int Radius { private get; set; }

        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + Color + ", x : " + X + ", y :" + Y + ", radius :" + Radius);
        }
    }
}
