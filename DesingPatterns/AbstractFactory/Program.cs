using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadLine();
        }

        static Application ConfigureApplication()
        {
            Application app;
            ITrasnportFactory trasnportFactory;
            string company = "99";

            if(company == "Uber")
            {
                trasnportFactory = new UberTransport();
            }
            else
            {
                trasnportFactory = new NineNineTransport();
            }

            app = new Application(trasnportFactory);

            return app;
        }
    }
}
