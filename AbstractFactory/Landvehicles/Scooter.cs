using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Passageiro liberado!");
        }

        public void StrartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando contagem de tempo.");
            Console.WriteLine();
        }
    }
}
