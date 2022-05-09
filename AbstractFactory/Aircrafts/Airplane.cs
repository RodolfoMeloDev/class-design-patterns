using System;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircrafts
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 25km, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo, voô autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem.");
            Console.WriteLine();
        }
    }
}
