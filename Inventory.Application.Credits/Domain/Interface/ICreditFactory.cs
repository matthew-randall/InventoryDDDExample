using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Credits.Domain.Interface
{
    internal interface ICreditFactory
    {
        ICredit GetCreditWorkflow(CreditDt creditDt);
        ICredit GetCreditWorkflow();
    }
}
