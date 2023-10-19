using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class NineNineTransport : ITrasnportFactory
    {
        public IAirCrafts CreateTransportAirCraft()
        {
            return new Helicopter();
        }

        public ILandVehicles CreateTransportVehicles()
        {
            return new MotoCycle();
        }
    }
}
