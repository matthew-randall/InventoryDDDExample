using System;
using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Application.Credits.Contracts.Commands;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
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
