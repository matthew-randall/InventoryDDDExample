using Inventory.Application.Base.Contacts.Structs;

namespace Inventory.Application.Credits.Contracts.Queries
{
    public class CreditViewQuery
    {
        public string CreditNumber { get; set; }
        public string CustomerCode { get; set; }
        public string InvoiceNumber { get; set; }
        public string CreditDate { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public Currency Total { get; set; }
    }
}
