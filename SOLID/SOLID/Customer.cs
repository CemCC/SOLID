using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Aim is to add the customers 
    class Customer
    {   
        public void Add()
        {
            var logging = new Logger();
            try
            {
                Console.WriteLine("Added Customer");
            }
            catch (Exception ex) // Solution: Logging is handled by Logger Class, Therefore it satisfiys the single responsibility.
            {
                logging.Handle(ex);
            }
        }
    }
}
