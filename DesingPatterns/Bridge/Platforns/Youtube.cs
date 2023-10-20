using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforns
{
    class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRNTP();
            Console.WriteLine("youtube: transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("youtube: autorizando aplicação");
        }

        public void ConfigureRNTP()
        {
            AuthToken();
            Console.WriteLine("youtube: configurando servidor RNTP");
        }
    }
}
