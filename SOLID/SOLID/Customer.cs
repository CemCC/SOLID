using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Customer
    {
        public void Add()
        {
            try
            {
                Console.WriteLine("Added Customer");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cannot add customer due to {ex}");
            }
        }
    }
}
