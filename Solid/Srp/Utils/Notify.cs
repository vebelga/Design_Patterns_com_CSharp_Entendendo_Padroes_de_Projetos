using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp.Utils
{
    //Organizando principio SRP - Single Responsibility Principle do SOLID de acordo com as responsabilidades de cada classe
    class Notify
    {
        public Notify(Client client)
        {
            Console.WriteLine("Notificando o cliente");        
        }
    }
}
