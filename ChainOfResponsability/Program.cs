using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;

        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite seu e-mail:");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha:");
                string password = Console.ReadLine();

               done = server.LogIn(email, password);

            } while (!done);

            Console.ReadLine();
        }

        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@hcode.com.br", "1615616dasdasd");

            server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            middleware.LinkWith(new CheckWeakPasswordMiddleware());

            server.SetMiddleware(middleware);
        }
    }
}
