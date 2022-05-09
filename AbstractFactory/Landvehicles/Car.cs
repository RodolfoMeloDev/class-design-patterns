using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Car : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros!");
        }

        public void StrartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
            Console.WriteLine();
        }
    }
}
