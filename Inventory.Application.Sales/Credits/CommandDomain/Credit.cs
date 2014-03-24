using System;
using System.Collections.Generic;
using Inventory.Application.Sales.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.Application.Sales.Credits.CommandDomain
{
    internal class Credit : BaseCredit, ICredit, ICreditNote
    {
        public Credit(CreditDt creditNoteMap)
            : base(creditNoteMap)
        {

        }

        public ISalesInvoice SalesInvoice
        {
            get { throw new NotImplementedException(); }
        }

        public CreditViewCommand GetCreditViewModel()
        {
            throw new System.NotImplementedException();
        }

        public ICreditLine GetCreditNoteLine(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateCreditLines(IEnumerable<ISalesInvoiceLine> salesInvoiceLine)
        {
            throw new System.NotImplementedException();
        }
    }
}
