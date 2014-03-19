namespace Inventory.Application.Sales.CommandDomain.Interface
{
    internal interface ISalesOrderLine
    {
        int SalesOrderLineId { get; }
        int LineNumber { get; }
        int Quantity { get; }
        decimal UnitPrice { get; }
        decimal DiscountRate { get; }
        decimal DiscountPrice { get; }
        decimal TaxRate { get; }
        decimal Total { get; }
        decimal Margin { get; }
        IWarehouseProduct WarehouseProduct { get; }
        ISalesOrder SalesOrder { get; }
        bool IsStockAllocated { get; }
        void Delete();
        void Park();
        void Complete();
        void AllocateStock();
        void DeallocateStock();
    }
}
