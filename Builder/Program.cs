using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ContructorSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {sedan.VehicleType}");
            Console.WriteLine(sedan.ToString());

            director.ContructorTruck();

            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {truck.VehicleType}");
            Console.WriteLine(truck.ToString());

            director.ContructorSUV();

            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {suv.VehicleType}");
            Console.WriteLine(suv.ToString());

            Console.ReadLine();
        }
    }
}
