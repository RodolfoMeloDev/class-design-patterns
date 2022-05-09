using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    class NineTransport : ITransportFactory
    {
        public IAircrafts CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }
    }
}
