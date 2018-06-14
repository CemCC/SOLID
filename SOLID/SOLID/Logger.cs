using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Logger
    {
        public void Handle(Exception exeption)
        {
            Console.WriteLine($"Cannot add customer due to {exeption}");
        }
    }
}
