using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Payments
{
    class DebitCard: NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Saldo Disponível");
        }
    }
}
