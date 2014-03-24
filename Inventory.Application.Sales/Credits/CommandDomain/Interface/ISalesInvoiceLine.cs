using System;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.Application.Sales.Credits.CommandDomain.Interface
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
