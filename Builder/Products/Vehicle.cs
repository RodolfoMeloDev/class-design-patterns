using Builder.Components;

namespace Builder.Products
{
    class Vehicle
    {
        private VehicleType _vehicleType;
        private int _seats;
        private Engine _engine;
        private Transmission _transmission;
        private Airbags _airbags;

        public VehicleType VehicleType
        {
            get => _vehicleType;
            set => _vehicleType = value;
        }

        public int Seats
        {
            get => _seats;
            set => _seats = value;
        }

        public Engine Engine
        {
            get => _engine;
            set => _engine = value;
        }

        public Transmission Transmission
        {
            get => _transmission;
            set => _transmission = value;
        }

        public Airbags Airbags
        {
            get => _airbags;
            set => _airbags = value;
        }

        public override string ToString()
        {
            return $"Componentes do carro:\n" +
                $"Tipo: {_vehicleType}\n" +
                $"Motor: {_engine.Power}\n" +
                $"Assentos: {_seats}\n" +
                $"Transmissão: {_transmission}\n" +
                $"AirBags: {(_airbags == null ? "Não" : "Sim")}\n";
        }
    }
}
