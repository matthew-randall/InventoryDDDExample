using System;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain.Interface
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
        SalesInvoiceLineViewModel GetSalesInvoiceLineViewModel();
    }
}
