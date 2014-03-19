using Inventory.Application.Credits.CommandDomain.Interface;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain
{
    internal class CreditFactory : ICreditFactory
    {
        public ICredit GetCreditWorkflow(CreditDt creditDt)
        {
            throw new System.NotImplementedException();
        }
    }
}
