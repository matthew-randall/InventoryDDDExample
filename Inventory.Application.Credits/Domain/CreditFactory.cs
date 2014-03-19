using Inventory.Application.Credits.Domain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain
{
    internal class CreditFactory : ICreditFactory
    {
        public ICredit GetCreditWorkflow(CreditDt creditDt)
        {
            throw new System.NotImplementedException();
        }

        public ICredit GetCreditWorkflow()
        {
            throw new System.NotImplementedException();
        }
    }
}
