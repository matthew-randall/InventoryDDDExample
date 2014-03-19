﻿using System;
using Inventory.Repository.Base.Contracts.Enum;

namespace Inventory.Application.Credits.Domain.Interface
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