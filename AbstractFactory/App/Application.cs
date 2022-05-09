using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
    class Application
    {
        private IAircrafts _aircraft;
        private ILandvehicle _vehicle;

        public Application(ITransportFactory factory)
        {
            _aircraft = factory.CreateTransportAircraft();
            _vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            _aircraft.StartRoute();
            _vehicle.StrartRoute();
        }
    }
}
