using System.Collections.Generic;
using Inventory.UI.Sales.Contracts.Credits.Queries;

namespace Inventory.UI.Sales.Contracts
{
    public interface IGetCreditViewList
    {
        List<CreditViewQuery> Get(int pageSize);
    }
}
