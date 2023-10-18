﻿using FactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport(); 
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotoCycleTransport();
            }
            else if (args.Length > 0 && args[0] == "--bike")
            {
                transport = new BicycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço");
            }

            if (transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();
        }
    }
}
