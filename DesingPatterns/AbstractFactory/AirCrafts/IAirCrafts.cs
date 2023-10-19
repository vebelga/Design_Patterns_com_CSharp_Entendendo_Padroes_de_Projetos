using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AirCrafts
{
    interface IAirCrafts
    {
        void StartRoute();
        void GetCargo();
        void CheckWind();

    }
}
