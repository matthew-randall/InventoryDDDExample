using System;
using System.Collections.Generic;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
{
    internal class Company : ICompany
    {
        public CurrencyDt DefaultCurrency
        {
            get { throw new NotImplementedException(); }
        }

        public WarehouseDt DefaultWarehouse
        {
            get { throw new NotImplementedException(); }
        }

        public SalesTaxDt DefaultSalesTax
        {
            get { throw new NotImplementedException(); }
        }

        public List<CreditReasonDt> CreditReasons
        {
            get { throw new NotImplementedException(); }
        }

        public List<WarehouseDt> Warehouses
        {
            get { throw new NotImplementedException(); }
        }

        public CreditReasonDt DefaultCreditReason
        {
            get { throw new NotImplementedException(); }
        }
    }
}
