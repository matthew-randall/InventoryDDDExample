using System;
using Inventory.Helpers.Enum;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Application.Sales.Credits.CommandDomain.Interface
{
    internal interface IFreeCreditNote
    {
        ICustomer Customer { get; }
        Guid CreditId { get; }
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
