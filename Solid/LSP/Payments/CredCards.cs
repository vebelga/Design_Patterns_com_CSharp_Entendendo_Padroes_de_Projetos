using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Payments
{
    class CredCards: NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Limite Ok");
        }
    }
}
