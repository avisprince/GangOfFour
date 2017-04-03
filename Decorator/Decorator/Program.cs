using Decorator.Decorator;
using Decorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var circle = new Circle();

            var redCircle = new RedShapeDecorator(new Circle());

            var redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();
        }
    }
}
