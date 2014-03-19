using System;
using Inventory.Application.Credits.Contracts.Commands;

namespace Inventory.Application.Credits.CommandDomain.Interface
{
    internal interface ICreditLine
    {
        Guid CreditLineId { get; }
        decimal CreditPrice { get; }
        decimal CreditQuantity { get; }
        decimal LineTax { get; }
        decimal SubTotal { get; }
        decimal Total { get; }
        int LineNumber { get; }
        bool ReturnToStock { get; }
        string Notes { get; }
        Guid CreditReasonId { get; }
        CreditLineViewCommand GetCreditLineViewModel();
        void Update(CreditLineViewCommand creditLineView);
    }
}
