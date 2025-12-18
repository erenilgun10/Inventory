using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DAL.ViewModels;

public class LowStockProductVm
{
    public int ProductId { get; set; }
    public string? Barcode { get; set; }
    public string ProductName { get; set; } = "";
    public string CategoryName { get; set; } = "";
    public string? SupplierName { get; set; }
    public int Stock { get; set; }
    public int MinStock { get; set; }
}
