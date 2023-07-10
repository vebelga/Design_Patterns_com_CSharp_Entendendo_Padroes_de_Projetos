using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicle
{
    class Car: Vehicle
    {
        private int seats;
        private int doors;

        public Car(string color, int yerar, double engine, int seats, int doors): base(color, yerar, engine)
        {
            this.seats = seats;
            this.doors = doors;
            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine("Criando um carro");
            StartVeiculo();
        }
    }
}
