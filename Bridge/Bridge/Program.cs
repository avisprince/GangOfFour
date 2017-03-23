using Bridge.DrawAPI;
using Bridge.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var redCircle = new Circle(100, 100, 10, new RedCircle());
            var greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
