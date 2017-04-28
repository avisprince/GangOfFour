using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Model
{
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying: " + this.fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading: " + fileName);
        }
    }
}
