using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

        public static SingleObject GetInstance()
        {
            return instance;
        }

        public void Run()
        {
            Console.WriteLine("Running single object class");
        }
    }
}
