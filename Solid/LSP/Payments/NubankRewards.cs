using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Payments
{
    class NubankRewards : IPaymentsInstrument
    {
        public void ColectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite Ok");
        }
    }
}
