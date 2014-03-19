using System;
using System.Collections.Generic;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain.Interface
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
        SalesInvoiceViewModel GetSalesInvoiceViewModel();
        Guid CreateNewCredit();
    }
}
