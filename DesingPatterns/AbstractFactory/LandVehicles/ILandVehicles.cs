using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    interface ILandVehicles
    {
        void StartRoute();
        void GetCargo();
    }
}
