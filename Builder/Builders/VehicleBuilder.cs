using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    class VehicleBuilder : IBuilder
    {
        private Vehicle _vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = _vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            _vehicle = new Vehicle();
        }        

        public void SetEngine(Engine engine)
        {
            _vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            _vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            _vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            _vehicle.VehicleType = vehicleType;
        }

        public void SetAirBag(Airbags airbags)
        {
            _vehicle.Airbags = airbags;
        }
    }
}
