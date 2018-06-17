using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegragation
{/// <summary>
/// Dedicated interface only for Driver
/// </summary>
    public interface IDriver
    {
        void DriveCar();
        void StopCar();
    }
}
