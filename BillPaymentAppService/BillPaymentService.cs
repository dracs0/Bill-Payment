using BillsLibrary;

namespace BillPaymentAppService
{
    public class PaymentService
    {
        public Models CreatePayment(string username, string bank, string amount, string method, string billType)
        {
            return new Models
            {
                PaymentId = Guid.NewGuid(),
                Username = username,
                Bank = bank,
                Amount = amount,
                PaymentMethod = method,
                BillType = billType
            };
        }

        public void PrintReceipt(Models payment)
        {
            payment.DisplayReceipt();
            Console.WriteLine($"Transaction ID: {payment.PaymentId}");
            Console.WriteLine($"Date: {DateTime.Now}");
        }
    }
}