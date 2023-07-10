using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicle
{
    class MotoCycle: Vehicle
    {
        public MotoCycle(string color, int yerar, double engine) : base(color, yerar, engine)
        {
            ConfigureMotoCycle();
        }

        public void ConfigureMotoCycle()
        {
            Console.WriteLine("Criando uma moto");
            StartVeiculo();
        }
    }
}
