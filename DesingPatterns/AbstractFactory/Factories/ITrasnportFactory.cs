using AbstractFactory.AirCrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    interface ITrasnportFactory
    {
        IAirCrafts CreateTransportAirCraft();
        ILandVehicles CreateTransportVehicles();
    }
}
