using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegragation
{
    public class Driver: IAutomobile
    {
        // Group 1: Driving activities that belong to a driver
        public void DriveCar() { /*Code to drive car */  }
        public void StopCar() { /* Code to stop car*/ }

        // Group 2: Sales activities that belong to a salesman
        public void SellCar() { /* no action needed for a Driver */ }
        public void BuyCar() { /* no action needed for a Driver */ }
        public void LeaseCar() { /* no action needed for a Driver */ }

    }
}
