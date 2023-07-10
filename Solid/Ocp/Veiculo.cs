using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    //Infringindo o principio OCP - Open/Closed principle
    class Veiculo
    {
        private string color;
        private int yerar;
        private double engine;
        private int seats;
        private int doors;

        public Veiculo(string color, int yerar, double engine, int seats, int doors)
        {
            this.color = color;
            this.yerar = yerar;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

        }
        public void Car()
        {
            Console.WriteLine("Criando um carro");
            StartVeiculo();
        }

        public void Motocycle()
        {
            Console.WriteLine("Criando uma moto");
            StartVeiculo();
        }

        public void StartVeiculo()
        {
            Console.WriteLine("Ligando o veiculo");
        }
    }
}
