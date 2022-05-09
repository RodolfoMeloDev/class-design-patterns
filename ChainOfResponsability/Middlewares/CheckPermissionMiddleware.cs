using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@hcode.com.br"))
            {
                Console.WriteLine("Seja Bem-vindo administrador!");
                return true;
            }

            Console.WriteLine("Seja Bem-vindo!");

            return CheckNext(email, password);
        }
    }
}
