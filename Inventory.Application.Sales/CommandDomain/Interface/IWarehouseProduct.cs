namespace Inventory.Application.Sales.CommandDomain.Interface
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
