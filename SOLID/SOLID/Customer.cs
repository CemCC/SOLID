using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Aim is to add the customers 
    class Customer
    {   // Principle: Every class should have single responsibility
        public void Add()
        {
            try
            {
                Console.WriteLine("Added Customer");
            }
            catch (Exception ex) // Problem : This class is created only for adding customers.
            {
                Console.WriteLine($"Cannot add customer due to {ex}");
            }
        }
    }
}
