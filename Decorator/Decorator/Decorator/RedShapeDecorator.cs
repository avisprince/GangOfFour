using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            this.DecoratedShape.Draw();
            this.SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
