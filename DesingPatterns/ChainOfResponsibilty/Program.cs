using ChainOfResponsibilty.Middlewares;
using ChainOfResponsibilty.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    internal class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@hcode.com.br", "123");
            server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware());

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a senha");
                string password = Console.ReadLine();

                done = server.Login(email, password);
            }while (!done);

            Console.ReadLine();
        }


    }
}
