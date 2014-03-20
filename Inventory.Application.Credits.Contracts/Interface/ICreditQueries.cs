using System.Collections.Generic;
using Inventory.Application.Credits.Contracts.Queries;

namespace Inventory.Application.Credits.Contracts.Interface
{
    public interface ICreditQueries
    {
        List<CreditViewQuery> GetCreditViewList(int pageSize);
    }
}
