using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class Toyota: Car
    {
        public override double Cost()
        {
            return 10000;
        }
    }
}
