using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Payments
{
    abstract class NubankCard : IPaymentsInstrument
    {
        public virtual void ColectPayment()
        {
            Console.WriteLine("Pagamento realizado");
        }

        public virtual void Validate()
        {
            //Validação base do cartão

        }
    }
}
