using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.OpenClose;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var car = new Toyota();
            Console.WriteLine(car.Cost());

            Console.ReadLine();
        }
    }
}
