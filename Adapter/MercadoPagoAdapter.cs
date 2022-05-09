using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            _mercadoPago.SendPaymentMP();
        }

        public void PayPalReceive()
        {
            _mercadoPago.ReceivePaymentMP();
        }
    }
}
