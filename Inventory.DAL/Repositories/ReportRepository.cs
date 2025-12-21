using Inventory.DAL.ViewModels;
using Microsoft.Data.SqlClient;

namespace Inventory.DAL.Repositories;

public class ReportRepository
{
    public List<LowStockProductVm> GetLowStock()
    {
        var list = new List<LowStockProductVm>();
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand("SELECT * FROM vw_LowStockProducts", con);
        con.Open();

        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new LowStockProductVm
            {
                ProductId = (int)r["ProductId"],
                Barcode = r["Barcode"] as string,
                ProductName = (string)r["ProductName"],
                CategoryName = (string)r["CategoryName"],
                SupplierName = r["SupplierName"] as string,
                Stock = (int)r["Stock"],
                MinStock = (int)r["MinStock"]
            });
        }
        return list;
    }

    public List<DailySalesSummaryVm> GetDailySales()
    {
        var list = new List<DailySalesSummaryVm>();
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand("SELECT * FROM vw_DailySalesSummary ORDER BY SalesDate ", con);
        con.Open();

        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new DailySalesSummaryVm
            {
                SalesDate = (DateTime)r["SalesDate"],
                TotalQuantity = (int)r["TotalQuantity"],
                TotalRevenue = (decimal)r["TotalRevenue"]
            });
        }
        return list;
    }

    public List<ProductSalesSummaryVm> GetProductSales()
    {
        var list = new List<ProductSalesSummaryVm>();
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand("SELECT * FROM vw_ProductSalesSummary ORDER BY Revenue ", con);
        con.Open();

        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new ProductSalesSummaryVm
            {
                ProductId = (int)r["ProductId"],
                ProductName = (string)r["ProductName"],
                SoldQuantity = (int)r["SoldQuantity"],
                Revenue = (decimal)r["Revenue"]
            });
        }
        return list;
    }
    public List<DailyPurchaseSummaryVm> GetDailyPurchases()
    {
        var list = new List<DailyPurchaseSummaryVm>();
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand("SELECT * FROM vw_DailyPurchaseSummary ORDER BY PurchaseDate ", con);
        con.Open();

        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new DailyPurchaseSummaryVm
            {
                PurchaseDate = (DateTime)r["PurchaseDate"],
                TotalQuantity = (int)r["TotalQuantity"],
                TotalCost = (decimal)r["TotalCost"]
            });
        }
        return list;
    }

}
