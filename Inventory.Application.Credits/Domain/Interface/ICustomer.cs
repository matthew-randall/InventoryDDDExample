using System;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain.Interface
{
    internal interface ICustomer
    {
        int CreateFreeCredit();
        Guid CustomerId { get; }
        string CustomerCode { get; }
        string CustomerName { get; }
        string Email { get; }
        CurrencyDt Currency { get; }
        WarehouseDt Warehouse { get; }
        ICompany Company { get; }
        bool Taxable { get; }
        SalesTaxDt SalesTax { get; }
    }
}
