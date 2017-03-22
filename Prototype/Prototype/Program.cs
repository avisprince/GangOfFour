using Prototype.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeCache.InitCache();

            var shape1 = ShapeCache.GetShape("1");
            var shape2 = ShapeCache.GetShape("2");
            var shape3 = ShapeCache.GetShape("3");

            Console.WriteLine("Shape: " + shape1.Type);
            Console.WriteLine("Shape: " + shape2.Type);
            Console.WriteLine("Shape: " + shape3.Type);
        }
    }
}
