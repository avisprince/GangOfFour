using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Model
{
    public class Rectangle : Shape
    {
        public override string Type
        {
            get
            {
                return "Rectangle";
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
