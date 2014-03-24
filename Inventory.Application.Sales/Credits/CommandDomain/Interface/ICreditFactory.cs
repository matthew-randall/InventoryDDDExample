using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Application.Sales.Credits.CommandDomain.Interface
{
    internal interface ICreditFactory
    {
        ICredit GetCreditWorkflow(CreditDt creditDt);
    }
}
