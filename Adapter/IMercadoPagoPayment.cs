namespace Adapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void SendPaymentMP();
        void ReceivePaymentMP();
    }
}
