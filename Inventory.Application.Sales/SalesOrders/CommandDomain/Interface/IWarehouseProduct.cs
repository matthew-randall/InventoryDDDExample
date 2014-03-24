namespace Inventory.Application.Sales.SalesOrders.CommandDomain.Interface
{
    internal interface IWarehouseProduct
    {
        int WarehouseProductId { get; }
        string ProductCode { get; }
        string Description { get; }
        int StockAvaliable { get; }
        bool IsNeverDiminishing { get; }
        void AllocateStock();
        void DeallocateStock();
    }
}
