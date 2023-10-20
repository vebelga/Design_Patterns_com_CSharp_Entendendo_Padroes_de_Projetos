using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paypal payments = new Paypal();
            IPayPalPayment payments = new PayonnerAdapter(new Payonner()); 

            payments.PayPalPayment();
            payments.PayPalReceive();

            Console.ReadLine();
        }
    }
}
