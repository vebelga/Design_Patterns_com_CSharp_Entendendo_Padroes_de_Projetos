﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Paypal : IPayPalPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
