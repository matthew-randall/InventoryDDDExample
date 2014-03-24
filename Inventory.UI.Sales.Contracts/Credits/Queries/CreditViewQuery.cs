using System;
using Inventory.Helpers.Enum;
using Inventory.Helpers.Structs;

namespace Inventory.UI.Sales.Contracts.Credits.Queries
{
    public class CreditViewQuery
    {
        public Guid CreditId { get; set; }
        public DocumentNumber CreditNumber { get; set; }
        public Code CustomerCode { get; set; }
        public DocumentNumber InvoiceNumber { get; set; }
        public DateTime CreditDate { get; set; }
        public PersonName CustomerName { get; set; }
        public CreditStatus Status { get; set; }
        public Monetary Total { get; set; }
    }
}
