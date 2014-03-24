using System;
using Inventory.Helpers.Enum;
using Inventory.Helpers.Structs;
using Inventory.UI.Sales.Contracts.Credits.Queries;

namespace Inventory.Application.Sales.Credits.QueryDomain.Interfaces
{
    internal interface ICreditView
    {
        Guid CreditId { get; }
        string CreditNumber { get; }
        string InvoiceNumber { get; }
        string CustomerCode { get; }
        string CustomerName { get; }
        DateTime CreditDate { get; }
        CreditStatus CreditStatus { get; }
        Monetary Total { get; }
        CreditViewQuery GetCreditViewQuery();
    }
}
