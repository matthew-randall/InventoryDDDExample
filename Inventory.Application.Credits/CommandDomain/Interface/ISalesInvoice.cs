using System;
using System.Collections.Generic;
using Inventory.Application.Credits.Contracts.Commands;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Application.Credits.CommandDomain.Interface
{
    internal interface ISalesInvoice
    {
        IEnumerable<ISalesInvoiceLine> SalesInvoiceLines { get; }
        Guid SalesInvoiceId { get; }
        string Notes { get; }
        decimal TaxRate { get; }
        DateTime InvoiceDate { get; }
        string CustomerRef { get; }
        DateTime RequiredDate { get; }
        string InvoiceNumber { get; }
        SalesInvoiceStatus InvoiceStatus { get; }
        ICustomer Customer { get; }
        SalesInvoiceViewCommand GetSalesInvoiceViewModel();
        Guid CreateNewCredit();
    }
}
