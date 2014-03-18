using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;

namespace Inventory.Repository.Sales.Contracts.Interface
{
    public interface IShipmentRetriever
    {
        List<ShipmentDt> GetShipmentsForInvoices(Guid[] salesInvoiceIds);
    }
}
