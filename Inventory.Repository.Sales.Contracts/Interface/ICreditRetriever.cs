using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Sales.Contracts.Interface
{
    public interface ICreditRetriever
    {
        IEnumerable<CreditViewDt> GetCreditsView(int pageSize);
    }
}
