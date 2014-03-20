using System;
using System.Collections.Generic;
using Inventory.Application.Base.Contacts.Structs;
using Inventory.Application.Credits.Contracts.Queries;
using Inventory.Application.Credits.QueryDomain.Interfaces;
using Inventory.Application.Credits.Services.ModelBuilders;
using Inventory.Application.Credits.Services.ModelBuilders.Interfaces;
using Inventory.Repository.Base.Contracts.Enum;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.QueryDomain
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

        public Currency Total
        {
            get { throw new NotImplementedException(); }
        }

        internal virtual ICreditViewQueryModelBuilder InstantiateCreditViewQueryModelBuilder()
        {
            return new CreditViewQueryModelBuilder();
        }
    }
}
