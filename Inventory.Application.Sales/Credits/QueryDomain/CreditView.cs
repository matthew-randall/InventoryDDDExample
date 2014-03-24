using System;
using System.Collections.Generic;
using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.Application.Sales.Credits.Services.ModelBuilders;
using Inventory.Application.Sales.Credits.Services.ModelBuilders.Interfaces;
using Inventory.Helpers.Enum;
using Inventory.Helpers.Structs;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Credits.Queries;

namespace Inventory.Application.Sales.Credits.QueryDomain
{
    internal class CreditView : ICreditView, ICreditInitialiser
    {
        private readonly CreditViewDt _creditViewDt;
        private readonly List<ICreditLineView> _creditLineViews;

        public CreditView(CreditViewDt creditViewDt)
        {
            _creditViewDt = creditViewDt;
            _creditLineViews = new List<ICreditLineView>();
        }

        public void InitialiseLine(ICreditLineView creditLineView)
        {
            _creditLineViews.Add(creditLineView);
        }

        public string CreditNumber
        {
            get { return _creditViewDt.CreditNumber; }
        }

        public CreditViewQuery GetCreditViewQuery()
        {
            var builder = InstantiateCreditViewQueryModelBuilder();
            var query = builder.Build(this);
            return query;
        }

        public IEnumerable<ICreditLineView> CreditLineViews
        {
            get { return _creditLineViews; }
        }

        public Guid CreditId
        {
            get { return _creditViewDt.CreditId; }
        }

        public string CustomerCode
        {
            get { return _creditViewDt.CustomerCode; }
        }

        public string CustomerName
        {
            get { return _creditViewDt.CustomerName; }
        }

        public DateTime CreditDate
        {
            get { return _creditViewDt.CreditDate; }
        }

        public string InvoiceNumber
        {
            get { return _creditViewDt.InvoiceNumber; }
        }

        public CreditStatus CreditStatus
        {
            get { return _creditViewDt.Status; }
        }

        public Monetary Total
        {
            get
            {
                Monetary total = 0m;

                foreach (var line in CreditLineViews)
                    total += line.Total;

                return total;
            }
        }

        internal virtual ICreditViewQueryModelBuilder InstantiateCreditViewQueryModelBuilder()
        {
            return new CreditViewQueryModelBuilder();
        }
    }
}
