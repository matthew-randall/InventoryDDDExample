using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.CommandDomain.Interface
{
    internal interface ICreditFactory
    {
        ICredit GetCreditWorkflow(CreditDt creditDt);
    }
}
