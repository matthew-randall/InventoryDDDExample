using System;
using System.Collections.Generic;
using Inventory.Repository.Base.Contracts.Models;
using Inventory.Repository.Sales.Contracts.Interface;

namespace Inventory.Repository.Fake
{
    public class ShipmentRepository : IShipmentRetriever
    {
        public List<ShipmentDt> GetShipmentsForInvoices(Guid[] salesInvoiceIds)
        {
            return new List<ShipmentDt>
            {
                new ShipmentDt
                {
                    ShipmentId = new Guid("BA079667-D9E5-4FAC-AD3A-5B7D1BC1D5E6"),
                    SalesInvoiceId = new Guid("8D83EC9B-600E-4915-B039-F8C6DAEF896D")
                },
                new ShipmentDt
                {
                    ShipmentId = new Guid("5E1932BB-47E7-4FC7-822E-415D3A9172B5"),
                    SalesInvoiceId = new Guid("8D83EC9B-600E-4915-B039-F8C6DAEF896D")
                },
                new ShipmentDt
                {
                    ShipmentId = new Guid("5B7C0B99-4FEE-4FAB-B26B-055C0CD5D279"),
                    SalesInvoiceId = new Guid("AC48F1E7-4CEC-4DAB-911E-BDF87311878F")
                },
            };
        }
    }
}
