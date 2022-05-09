using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    class Director
    {
        IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ContructorSedanCar()
        {
            _builder.SetVehicleType(VehicleType.SEDAN);
            _builder.SetEngine(new Engine(2000));
            _builder.SetSeats(5);
            _builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ContructorTruck()
        {
            _builder.SetVehicleType(VehicleType.TRUCK);
            _builder.SetEngine(new Engine(4000));
            _builder.SetSeats(2);
            _builder.SetTransmission(Transmission.MANUAL);
        }

        public void ContructorSUV()
        {
            _builder.SetVehicleType(VehicleType.SUV);
            _builder.SetEngine(new Engine(2600));
            _builder.SetSeats(4);
            _builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            _builder.SetAirBag(new Airbags());
        }
    }
}
