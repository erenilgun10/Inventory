
namespace Inventory.DAL.ViewModels;

public class DailyPurchaseSummaryVm
{
    public DateTime PurchaseDate { get; set; }
    public int TotalQuantity { get; set; }
    public decimal TotalCost { get; set; }
}
