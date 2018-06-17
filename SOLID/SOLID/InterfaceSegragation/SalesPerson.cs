using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegragation
{
    public class SalesPerson: ISalesPerson
    {
        // Group 1: Sales activities that belong to a salesman
        public void SellCar() { /* Code to Sell car */ }
        public void BuyCar() { /* Code to Buy car */ }
        public void LeaseCar() { /* Code to lease car */ }

    }
}
