using Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Program
    {
        private static string[] colors = new string[] { "Red", "Green", "Blue", "White", "Black" };

        private static Random random = new Random();

        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var circle = (Circle)ShapeFactory.GetCircle(GetRandomColor());
                circle.X = GetRandomX();
                circle.Y = GetRandomY();
                circle.Radius = 100;
                circle.Draw();
            }
        }

        private static string GetRandomColor()
        {
            return colors[random.Next(0, 4)];
        }

        private static int GetRandomX()
        {
            return random.Next(1, 100);
        }

        private static int GetRandomY()
        {
            return random.Next(1, 100);
        }
    }
}
