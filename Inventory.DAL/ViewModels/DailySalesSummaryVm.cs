using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DAL.ViewModels;

public class DailySalesSummaryVm
{
    public DateTime SalesDate { get; set; }
    public int TotalQuantity { get; set; }
    public decimal TotalRevenue { get; set; }
}
