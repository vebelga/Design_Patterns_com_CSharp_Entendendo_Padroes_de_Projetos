using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    class Bicycle: IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a entrega");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a corrida");
        }
    }
}
