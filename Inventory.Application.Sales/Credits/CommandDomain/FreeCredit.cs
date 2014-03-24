using System;
using System.Collections.Generic;
using Inventory.Application.Sales.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.Application.Sales.Credits.CommandDomain
{
    internal class FreeCredit : BaseCredit, ICredit, IFreeCreditNote
    {
        public FreeCredit(CreditDt creditNote)
            : base(creditNote)
        {
        }

        public ICustomer Customer
        {
            get { throw new NotImplementedException(); }
        }

        public CreditViewCommand GetCreditViewModel()
        {
            throw new NotImplementedException();
        }

        public ICreditLine GetCreditNoteLine(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateCreditLines(IEnumerable<ISalesInvoiceLine> salesInvoiceLine)
        {
            throw new NotImplementedException();
        }
    }
}
