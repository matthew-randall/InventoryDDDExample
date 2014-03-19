using System;
using Inventory.Application.Credits.Contracts.Commands;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain.Interface
{
    internal interface ISalesInvoiceLine
    {
        Guid SalesInvoiceLineId { get; }
        decimal InvoiceQuantity { get; }
        decimal UnitPrice { get; }
        decimal DiscountedUnitPrice { get; }
        string Notes { get; }
        ProductDt Product { get; }
        ISalesInvoice SalesInvoice { get; }
        SalesInvoiceLineViewCommand GetSalesInvoiceLineViewModel();
    }
}
