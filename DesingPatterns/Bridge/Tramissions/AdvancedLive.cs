using Bridge.Platforns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tramissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform) { }

        public void SubTitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live");
        }
    }
}
