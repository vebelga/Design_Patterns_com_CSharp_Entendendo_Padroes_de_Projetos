using Ocp.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.MotoCycle;

            if(type == TypeVehicle.Car)
            {
                Car veiculo = new Car("azul", 2022, 2.0, 5, 4);
            }
            else
            {
                MotoCycle veiculo = new MotoCycle("branco", 2023, 250);
            }

            Console.ReadLine();
        }
    }
}
