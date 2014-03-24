using System;
using Inventory.Application.Sales.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.Application.Sales.Credits.CommandDomain
{
    internal class CreditLine : BaseCreditLine, ICreditLine, ICreditNoteLine
    {
        public CreditLine(ICredit credit, CreditLineDt creditLine)
            : base( credit, creditLine)
        {
            
        }

        public CreditLineViewCommand GetCreditLineViewModel()
        {
            throw new NotImplementedException();
        }

        public void Update(CreditLineViewCommand creditLineView)
        {
            throw new NotImplementedException();
        }

        public virtual ISalesInvoiceLine SalesInvoiceLine
        {
            get { throw new NotImplementedException(); }
        }
    }
}
