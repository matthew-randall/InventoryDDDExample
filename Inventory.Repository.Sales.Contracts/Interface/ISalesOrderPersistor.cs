using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Sales.Contracts.Interface
{
    public interface ISalesOrderPersistor
    {
        void AddSalesOrder(SalesOrderDt salesOrderDt);
    }
}
