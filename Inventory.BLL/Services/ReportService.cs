using System.Collections.Generic;
using Inventory.DAL.Repositories;
using Inventory.DAL.ViewModels;

namespace Inventory.BLL.Services
{
    public class ReportService
    {
        private readonly ReportRepository _repo = new();

        public List<LowStockProductVm> GetLowStock() => _repo.GetLowStock();
        public List<DailySalesSummaryVm> GetDailySales() => _repo.GetDailySales();
        public List<ProductSalesSummaryVm> GetProductSales() => _repo.GetProductSales();
        public List<DailyPurchaseSummaryVm> GetDailyPurchases() => _repo.GetDailyPurchases();

    }
}
