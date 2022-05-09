using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircrafts
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda preparada.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Inciando entrega.");
            Console.WriteLine();
        }
    }
}
