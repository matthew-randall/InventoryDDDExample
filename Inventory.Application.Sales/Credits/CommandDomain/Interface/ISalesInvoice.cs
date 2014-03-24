using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.Application.Sales.Credits.CommandDomain.Interface
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
