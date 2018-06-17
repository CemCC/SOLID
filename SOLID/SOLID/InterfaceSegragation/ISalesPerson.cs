using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegragation
{/// <summary>
/// Dedicated interface only for SalesPerson
/// </summary>
    public interface ISalesPerson
    {
        void SellCar();
        void BuyCar();
        void LeaseCar();
    }
}
