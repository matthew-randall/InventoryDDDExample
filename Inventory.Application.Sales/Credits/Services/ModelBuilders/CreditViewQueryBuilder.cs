using Inventory.Application.Sales.Credits.QueryDomain.Interfaces;
using Inventory.Application.Sales.Credits.Services.ModelBuilders.Interfaces;
using Inventory.UI.Sales.Contracts.Credits.Queries;

namespace Inventory.Application.Sales.Credits.Services.ModelBuilders
{
    internal class CreditViewQueryModelBuilder : ICreditViewQueryModelBuilder
    {
        public CreditViewQuery Build(ICreditView creditView)
        {
            var query = new CreditViewQuery
            {
                CreditId = creditView.CreditId,
                CreditNumber = creditView.CreditNumber,
                CustomerCode = creditView.CustomerCode,
                InvoiceNumber = creditView.InvoiceNumber,
                CreditDate = creditView.CreditDate,
                CustomerName = creditView.CustomerName,
                Status = creditView.CreditStatus,
                Total = creditView.Total
            };

            return query;
        }
    }
}
