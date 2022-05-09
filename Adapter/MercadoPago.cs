using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePaymentMP()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento do Mercado Pago");
        }

        public void SendPaymentMP()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento do Mercado Pago");
        }
    }
}
