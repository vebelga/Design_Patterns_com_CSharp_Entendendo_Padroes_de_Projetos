using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforns
{
    class Facebook: IPlatform
    {
        public Facebook()
        {
            ConfigureRNTP();
            Console.WriteLine("Facebook: transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: autorizando aplicação");
        }

        public void ConfigureRNTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: configurando servidor RNTP");
        }
    }
}
