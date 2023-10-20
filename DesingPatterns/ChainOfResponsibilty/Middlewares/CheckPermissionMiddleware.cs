using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if(email == "master@hcode.com.br")
            {
                Console.WriteLine("Seja bem-vindo administrador");
                return true;
            }

            Console.WriteLine("Seja vem-vindo");

            return CheckNext(email, password);
        }
    }
}
