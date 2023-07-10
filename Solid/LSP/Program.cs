using LSP.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CredCards cards = new CredCards();
            NubankRewards   cards = new NubankRewards();

            cards.Validate();
            cards.ColectPayment();

            Console.ReadLine();
        }

        
    }
}
