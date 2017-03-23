using Bridge.DrawAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shape
{
    public abstract class Shape
    {
        protected IDrawAPI drawAPI;

        protected Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
