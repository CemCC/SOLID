using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegragation
{/// <summary>
/// This interface is violating interface segragation principle. Because it includes 2 activities that belong to different groups (SalesPerson, Driver)
/// It should be splitted as two different interfaces.
/// </summary>
    public interface IAutomobile
    {
        void SellCar();
        void BuyCar();
        void LeaseCar();
        void DriveCar();
        void StopCar();
    }
}
