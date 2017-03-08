using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model.Color
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Filling in blue");
        }
    }
}
