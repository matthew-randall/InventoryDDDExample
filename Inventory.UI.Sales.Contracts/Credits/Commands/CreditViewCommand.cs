using System;
using System.Collections.Generic;
using Inventory.Helpers.Enum;
using Inventory.Helpers.Structs;

namespace Inventory.UI.Sales.Contracts.Credits.Commands
{
    public class CreditViewCommand
    {
        public DocumentNumber CreditNumber { get; set; }
        public Code CustomerCode { get; set; }
        public PersonName CustomerName { get; set; }
        public Email Email { get; set; }
        public CurrencyCode CustomerCurrency { get; set; }
        public CreditStatus CreditStatus { get; set; }
        public DocumentNumber InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime CreditDate { get; set; }
        public string Reference { get; set; }
        public List<CreditLineViewCommand> CreditLines { get; set; }
    }
}
