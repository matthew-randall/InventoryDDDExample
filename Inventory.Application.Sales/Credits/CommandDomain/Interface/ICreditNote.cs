using System;
using Inventory.Helpers.Enum;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Application.Sales.Credits.CommandDomain.Interface
{
    internal interface ICreditNote
    {
        Guid CreditId { get; }
        ISalesInvoice SalesInvoice { get; }
        string CreditNumber { get; }
        DateTime CreditDate { get; }
        CreditType CreditType { get; }
        string Notes { get; }
        CreditStatus CreditStatus { get; }
        decimal SubTotal { get; }
        decimal TaxTotal { get; }
        decimal Total { get; }
    }
}
