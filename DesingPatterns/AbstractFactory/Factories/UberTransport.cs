using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class UberTransport : ITrasnportFactory
    {
        public IAirCrafts CreateTransportAirCraft()
        {
            return new AirPlane();
        }

        public ILandVehicles CreateTransportVehicles()
        {
            return new Car();
        }
    }
}
