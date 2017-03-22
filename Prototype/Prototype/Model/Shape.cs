using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Model
{
    public abstract class Shape : ICloneable
    {
        public abstract void Draw();

        public string Id { get; set; }

        public abstract string Type { get; }

        public object Clone()
        {
            try
            {
                return base.MemberwiseClone();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
