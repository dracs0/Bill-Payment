using BillsLibrary;

namespace BillPaymentDataService
{
    public class PaymentDataService
    {
        private readonly List<Models> _payments = new List<Models>();

        public void SavePayment(Models payment)
        {
            _payments.Add(payment);
        }

        public IEnumerable<Models> GetPayments()
        {
            return _payments;
        }
    }
}