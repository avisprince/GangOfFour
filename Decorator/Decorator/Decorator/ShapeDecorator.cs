using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class ShapeDecorator : IShape
    {
        public ShapeDecorator(IShape shape)
        {
            this.DecoratedShape = shape;
        }

        public IShape DecoratedShape { get; private set; }

        public virtual void Draw()
        {
            this.DecoratedShape.Draw();
        }
    }
}
