using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Model
{
    public class Circle : Shape
    {
        public override string Type
        {
            get
            {
                return "Circle";
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}
