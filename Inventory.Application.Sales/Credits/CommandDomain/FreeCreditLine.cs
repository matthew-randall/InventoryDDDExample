using System;
using Inventory.Application.Sales.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.UI.Sales.Contracts.Credits.Commands;

namespace Inventory.Application.Sales.Credits.CommandDomain
{
    internal class FreeCreditLine : BaseCreditLine, ICreditLine, IFreeCreditLine
    {
        public FreeCreditLine(ICredit creditWorkflow, CreditLineDt creditLine)
            : base( creditWorkflow, creditLine)
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
    }
}
