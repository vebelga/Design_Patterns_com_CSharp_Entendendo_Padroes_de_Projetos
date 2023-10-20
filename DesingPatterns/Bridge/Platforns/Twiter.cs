using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforns
{
    class Twiter: IPlatform
    {
        public Twiter()
        {
            ConfigureRNTP();
            Console.WriteLine("Twiter: transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Twiter: autorizando aplicação");
        }

        public void ConfigureRNTP()
        {
            AuthToken();
            Console.WriteLine("Twiter: configurando servidor RNTP");
        }
    }
}
