using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAircrafts CreateTransportAircraft();
        ILandvehicle CreateTransportVehicle();
    }
}
