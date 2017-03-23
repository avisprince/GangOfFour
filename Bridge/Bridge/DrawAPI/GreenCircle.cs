using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DrawAPI
{
    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle: [color: green, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }
}
