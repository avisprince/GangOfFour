using Facade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ShapeMaker
    {
        public ShapeMaker()
        {
            this.Square = new Square();
            this.Circle = new Circle();
            this.Rectangle = new Rectangle();
        }

        public IShape Square { get; private set; }

        public IShape Circle { get; private set; }

        public IShape Rectangle { get; private set; }

        public void DrawSquare()
        {
            this.Square.Draw();
        }

        public void DrawCircle()
        {
            this.Circle.Draw();
        }

        public void DrawRectangle()
        {
            this.Rectangle.Draw();
        }
    }
}
