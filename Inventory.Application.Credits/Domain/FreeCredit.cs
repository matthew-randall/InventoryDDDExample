using System;
using System.Collections.Generic;
using Inventory.Application.Credits.Contracts.Model;
using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
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

        public CreditViewModel GetCreditViewModel()
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
