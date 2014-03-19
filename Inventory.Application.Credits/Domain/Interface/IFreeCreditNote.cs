﻿using System;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain.Interface
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
