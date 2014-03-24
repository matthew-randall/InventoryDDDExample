using System.Collections.Generic;
using Inventory.UI.Sales.Contracts.Credits.Queries;

namespace Inventory.UI.Sales.Contracts.Credits.Interface
{
    public interface ICreditQueries
    {
        List<CreditViewQuery> GetCreditViewList(int pageSize);
    }
}
