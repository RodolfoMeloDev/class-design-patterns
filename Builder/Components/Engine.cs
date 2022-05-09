namespace Builder.Components
{
    class Engine
    {
        private int _power;

        public int Power { 
            get => _power;
            set => _power = value; 
        }

        public Engine(int power)
        {
            _power = power;
        }
    }
}
