using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicle
{
    //Aplicando o principio OCP - Open/Closed principle
    class Vehicle
    {
        protected string color;
        protected int yerar;
        protected double engine;

        public Vehicle(string color, int yerar, double engine)
        {
            this.color = color;
            this.yerar = yerar;
            this.engine = engine;
        }

        public void StartVeiculo()
        {
            Console.WriteLine("Ligando o veiculo");
        }
    }
}
