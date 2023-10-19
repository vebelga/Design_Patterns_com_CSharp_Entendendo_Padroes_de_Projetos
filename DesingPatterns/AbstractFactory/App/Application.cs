using AbstractFactory.AirCrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAirCrafts airCrafts;
        private ILandVehicles vehicles;

        public Application(ITrasnportFactory factory)
        {
            airCrafts = factory.CreateTransportAirCraft();
            vehicles = factory.CreateTransportVehicles();
        }

        public void StartRoute()
        {
            vehicles.StartRoute();
            airCrafts.StartRoute();
        }
    }
}
