
namespace BillsLibrary
{
    public class Models
    {
        public Guid PaymentId { get; set; }
        public string Username { get; set; }
        public string Bank { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string BillType { get; set; }

        public void DisplayReceipt()
        {
            Console.WriteLine($"{BillType} bill of {Amount} paid successfully using {PaymentMethod} through {Bank}. Thank you for your payment!");
        }
    }
}