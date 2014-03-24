using System;
using Inventory.Application.Sales.SalesOrders.CommandDomain.Interface;
using Inventory.Application.Sales.SalesOrders.Services.ModelBuilders.Interface;
using Inventory.UI.Sales.Contracts.Models;

namespace Inventory.Application.Sales.SalesOrders.Services.ModelBuilders
{
    internal class SalesOrderVmModelBuilder : ISalesOrderVmModelBuilder
    {
        public SalesOrderVm Build(ISalesOrder salesOrder)
        {
            if (salesOrder == null) 
                throw new SalesOrderCannotBeNullException();

            var viewModel = new SalesOrderVm();

            AssignTotals(viewModel, salesOrder);
            AssignCustomerDetails(viewModel, salesOrder);
            AssignSalesInvoiceDetails(viewModel, salesOrder);
            AssignSalesOrderDetails(viewModel, salesOrder);

            return viewModel;
        }

        private void AssignCustomerDetails(SalesOrderVm viewModel, ISalesOrder salesOrder)
        {
            viewModel.CustomerCode = salesOrder.Customer.CustomerCode;
            viewModel.PrintInvoice = salesOrder.Customer.PrintInvoice;
            viewModel.PrintPackingSlip = salesOrder.Customer.PrintPackingSlip;
        }

        private void AssignTotals(SalesOrderVm viewModel, ISalesOrder salesOrder)
        {
            viewModel.SubTotal = salesOrder.SubTotal;
            viewModel.TaxTotal = salesOrder.TaxTotal;
            viewModel.Total = salesOrder.Total;
            viewModel.Margin = salesOrder.Margin;
            viewModel.Profit = salesOrder.Profit;
            viewModel.TotalVolume = salesOrder.TotalVolume;
            viewModel.TotalWeight = salesOrder.TotalWeight;
        }

        private void AssignSalesInvoiceDetails(SalesOrderVm viewModel, ISalesOrder salesOrder)
        {
            viewModel.OpenSalesInvoiceCount = salesOrder.GetOpenInvoices().Count;
        }

        private void AssignSalesOrderDetails(SalesOrderVm viewModel, ISalesOrder salesOrder)
        {
            viewModel.SalesOrderId = salesOrder.SalesOrderId;
            viewModel.OrderNumber = salesOrder.OrderNumber;
            viewModel.OrderDate = salesOrder.OrderDate;
            viewModel.RequiredDate = salesOrder.RequiredDate;
            viewModel.DiscountRate = salesOrder.DiscountRate;
        }

        public class SalesOrderCannotBeNullException : ApplicationException {}
    }
}
