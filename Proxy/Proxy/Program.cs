using Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            // image will be loaded from disk
            image.Display();

            // image will not be loaded from disk
            image.Display();
        }
    }
}
