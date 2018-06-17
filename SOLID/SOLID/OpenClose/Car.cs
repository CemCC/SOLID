using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public abstract class Car // why abstract class ? -- any child of mine MUST implement this method...
    {
        public abstract double Cost();
    }
}
