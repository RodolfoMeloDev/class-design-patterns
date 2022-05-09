using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class Live : ITransmission
    {
        protected IPlatform _Platform;

        public Live(IPlatform Platform)
        {
            _Platform = Platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na {_Platform}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
