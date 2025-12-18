using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DAL.ViewModels;

public class ProductSalesSummaryVm
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = "";
    public int SoldQuantity { get; set; }
    public decimal Revenue { get; set; }
}
