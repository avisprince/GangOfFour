using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Model
{
    public class Square : Shape
    {
        public override string Type
        {
            get
            {
                return "Square";
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
}
