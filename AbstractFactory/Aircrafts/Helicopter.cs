using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircrafts
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando ventos, ventos sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok. Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
            Console.WriteLine();
        }
    }
}
