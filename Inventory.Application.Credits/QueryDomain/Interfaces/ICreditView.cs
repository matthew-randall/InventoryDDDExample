using System;
using Inventory.Application.Credits.Contracts.Queries;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Application.Base.Contacts.Structs;

namespace Inventory.Application.Credits.QueryDomain.Interfaces
{
    internal interface ICreditView
    {
        CreditViewQuery GetCreditViewQuery();

        string CreditNumber { get; }
        string InvoiceNumber { get; }
        string CustomerCode { get; }
        string CustomerName { get; }
        DateTime CreditDate { get; }
        CreditStatus CreditStatus { get; }
        Currency Total { get; }
    }
}
