using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain.Interface
{
    internal interface ICompany
    {
        CurrencyDt DefaultCurrency { get; }
        WarehouseDt DefaultWarehouse { get; }
        SalesTaxDt DefaultSalesTax { get; }
        CreditReasonDt DefaultCreditReason { get; }
        List<CreditReasonDt> CreditReasons { get; }
        List<WarehouseDt> Warehouses { get; }
    }
}
